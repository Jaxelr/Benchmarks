using System.Collections.Generic;
using System.Globalization;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvBenchmark
{
    [BenchmarkCategory("Csv")]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class CsvBenchmark
    {
        private const string TestFile = "C:\\temp\\test.csv";

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public void GenerateCsv(List<Example> examples)
        {
            using var writer = new StreamWriter(TestFile);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                /* This Assures that all strings types are quoted */
                ShouldQuote = args =>
                {
                    if (args.FieldType == typeof(string) && args.Row.Row != 1) /* Exclude the header */
                    {
                        return true;
                    }

                    return false;
                }
            };

            using var csv = new CsvWriter(writer, config);

            csv.WriteRecords(examples);
        }

        [IterationCleanup]
        public static void DeleteExisting()
        {
            if (File.Exists(TestFile))
            {
                File.Delete(TestFile);
            }
        }

        public static IEnumerable<List<Example>> Arrays()
        {
            yield return CreateList(5_000);
            yield return CreateList(50_000);
            yield return CreateList(100_000);
        }

        public static List<Example> CreateList(int capacity)
        {
            var list = new List<Example>(capacity);
            for (int i = 0; i < capacity; i++)
                list.Add(new Example() { Id = i, Value = new string('x', i) });

            return list;
        }
    }
}
