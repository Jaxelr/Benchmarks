using System;
using System.Data.SqlClient;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Dapper;

namespace SQLConnectionBenchmark;

[BenchmarkCategory("SqlConnection")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[LongRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class SqlConnectionBenchmark
{
    private readonly string connString;
    private readonly SqlConnection connection;
    private int param;

    public SqlConnectionBenchmark()
    {
        //We do this to pass the connection from the build or locally
        connString = Environment.GetEnvironmentVariable("SQL_CONNECTION");
        if (string.IsNullOrEmpty(connString))
        {
            connString = "Server=127.0.0.1,1434;database=master;User Id=sa;Password=P@ssword123;MultipleActiveResultSets=true;";
        }

        connection = new SqlConnection(connString);
        connection.Open();
    }

    [Benchmark]
    public void WithUsingExecution()
    {
        using var cn = (new SqlConnection(connString));

        _ = cn.Query<int>("SELECT @param", new { param });

        _ = cn.Query<string>("SELECT @param", new { param });
    }

    [Benchmark]
    public void WithoutUsingExecution()
    {
        _ = connection.Query<int>("SELECT @param", new { param });
        _ = connection.Query<string>("SELECT @param", new { param });
    }

    [IterationSetup]
    public void Increment() => param++;

    [GlobalCleanup]
    public void DbCleanup()
    {
        connection?.Close();
        connection?.Dispose();
    }
}
