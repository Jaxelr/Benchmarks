using System.Net.Http;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Microsoft.Extensions.DependencyInjection;

namespace HttpBenchmark
{
    [BenchmarkCategory("HttpClient")]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [LongRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class HttpBenchmark
    {
        private const string GoogleUrl = "http://www.google.com";
        private const string CustomHeader = "X-Client-Test";
        private readonly string[] headerValues = new string[] { "Static", "Each", "Factory" };

        private readonly HttpClient staticClient = new();
        private readonly IHttpClientFactory httpClientFactory;

        public HttpBenchmark()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add(CustomHeader, headerValues[0]);

            staticClient = client;

            //Client Factory construction
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
        }

        [Benchmark]
        public async Task<string> StaticHttpClient() => await staticClient.GetStringAsync(GoogleUrl);

        [Benchmark]
        public async Task<string> EachHttpClient()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add(CustomHeader, headerValues[1]);

            return await client.GetStringAsync(GoogleUrl);
        }

        [Benchmark]
        public async Task<string> HttpClientFactory()
        {
            var client = httpClientFactory.CreateClient();

            client.DefaultRequestHeaders.Add(CustomHeader, headerValues[2]);

            return await client.GetStringAsync(GoogleUrl);
        }
    }
}
