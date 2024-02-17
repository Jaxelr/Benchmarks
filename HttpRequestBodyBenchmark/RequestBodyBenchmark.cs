using System.Buffers;
using System.IO;
using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Microsoft.AspNetCore.Http;

namespace HttpRequestBodyBenchmark;

[BenchmarkCategory("Http Request Body")]
[AllStatisticsColumn]
[MemoryDiagnoser]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[LongRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class RequestBodyBenchmark
{
    private readonly HttpContext httpContext;
    private const int ThreadCount = 4;

    public RequestBodyBenchmark()
    {
        httpContext = new DefaultHttpContext();
        var random = new Random();
        byte[] bytes = new byte[4096];
        random.NextBytes(bytes);
        httpContext.Request.Body = new MemoryStream(bytes);
    }

    [Benchmark]
    public async Task<byte[]> GetRequestBodyCopy()
    {
        var me = new MemoryStream();
        await httpContext.Request.Body.CopyToAsync(me);
        return me.ToArray();
    }

    [Benchmark]
    public async Task<byte[]> GetRequestBodyRent()
    {
        byte[] buffer = ArrayPool<byte>.Shared.Rent(4096);

        try
        {
            using var me = new MemoryStream();
            int read;

            while ((read = await httpContext.Request.Body.ReadAsync(buffer)) > 0)
            {
                me.Write(buffer, 0, read);
            }

            return me.ToArray();
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    [Benchmark]
    public async Task RunMultipleThreadsBodyCopy()
    {
        var tasks = new Task[ThreadCount];
        for (int i = 0; i < ThreadCount; i++)
        {
            tasks[i] = GetRequestBodyCopy();
        }

        await Task.WhenAll(tasks);
    }

    [Benchmark]
    public async Task RunMultipleThreadsBodyRent()
    {
        var tasks = new Task[ThreadCount];
        for (int i = 0; i < ThreadCount; i++)
        {
            tasks[i] = GetRequestBodyRent();
        }

        await Task.WhenAll(tasks);
    }
}
