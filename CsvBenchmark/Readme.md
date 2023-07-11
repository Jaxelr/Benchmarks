# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.304
  [Host]   : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |     StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     64.33 ms |     89.09 ms |     4.883 ms |   2.819 ms |     58.69 ms |     67.25 ms | 15.5443 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,089.81 ms |  3,640.58 ms |   199.552 ms | 115.212 ms |  2,913.99 ms |  3,306.70 ms |  0.3236 | 288000.0000 |         - |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 12,994.03 ms | 20,392.13 ms | 1,117.762 ms | 645.340 ms | 12,195.71 ms | 14,271.48 ms |  0.0770 | 293000.0000 | 4000.0000 | 1000.0000 | 9568.94 MB |
