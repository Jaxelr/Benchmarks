using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Microsoft.Extensions.Logging;

namespace LoggingBenchmark;

[BenchmarkCategory("Logging")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[LongRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class LoggingBenchmark
{
    private readonly ILogger<LoggingBenchmark> logger;
    private string message;
    private const string ConstantMessage = "lorem ipsum dolor sit amet";

    public LoggingBenchmark()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        logger = loggerFactory.CreateLogger<LoggingBenchmark>();
    }

    [IterationSetup]
    public void Setup()
    {
        byte[] digest = new byte[32];
        var random = new Random();
        random.NextBytes(digest);

        message = Convert.ToBase64String(digest);
    }

    [Benchmark]
    public void LogInformationMessage() => logger.LogInformation(message);

    [Benchmark]
    public void LogInformationConst() => logger.LogInformation(ConstantMessage);
}
