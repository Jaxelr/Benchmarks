# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.301
  [Host]   : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  ShortRun : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |    Op/s |       Gen 0 | Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     36.94 ms |    163.31 ms |     8.951 ms |     5.168 ms |     30.93 ms |     31.80 ms |     32.67 ms |     39.95 ms |     47.23 ms | 27.0698 |   4000.0000 |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,911.43 ms |  7,773.30 ms |   426.081 ms |   245.998 ms |  2,420.37 ms |  2,775.48 ms |  3,130.58 ms |  3,156.95 ms |  3,183.33 ms |  0.3435 | 288000.0000 |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 16,097.41 ms | 39,211.21 ms | 2,149.299 ms | 1,240.898 ms | 14,233.32 ms | 14,921.92 ms | 15,610.51 ms | 17,029.45 ms | 18,448.38 ms |  0.0621 | 290000.0000 |  9,569 MB |
