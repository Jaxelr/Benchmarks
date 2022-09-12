using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ReplaceBenchmark
{
    [BenchmarkCategory("Replace")]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class ReplaceBenchmark
    {
        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public string ReplaceString(string value) => value.Replace("*", string.Empty);

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public string ReplaceStringBuilder(string value)
        {
            var builder = new StringBuilder(value);

            return builder.Replace("*", string.Empty).ToString();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public string ReplaceRegexBuilder(string value) => Regex.Replace(value, ".*", string.Empty);

        public static IEnumerable<object[]> Arrays()
        {
            yield return new object[] { new string('*', 500) };
            yield return new object[] { new string('*', 1000) };
            yield return new object[] { "Random*String*With*Asterisks*In*Between" };
        }
    }
}
