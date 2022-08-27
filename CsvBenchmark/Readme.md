# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |    Op/s |       Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     23.80 ms |     17.49 ms |     0.959 ms |     0.554 ms |     23.04 ms |     23.26 ms |     23.48 ms |     24.18 ms |     24.88 ms | 42.0186 |   4000.0000 |         - |         - |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,488.92 ms | 11,800.59 ms |   646.830 ms |   373.448 ms |  3,842.45 ms |  4,165.33 ms |  4,488.21 ms |  4,812.16 ms |  5,136.11 ms |  0.2228 | 288000.0000 |         - |         - |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 16,363.41 ms | 63,126.04 ms | 3,460.151 ms | 1,997.719 ms | 12,762.87 ms | 14,713.32 ms | 16,663.77 ms | 18,163.68 ms | 19,663.59 ms |  0.0611 | 295000.0000 | 4000.0000 | 1000.0000 |  9,569 MB |
