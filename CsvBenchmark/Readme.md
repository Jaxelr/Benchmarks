# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |      StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |    Op/s |       Gen 0 |     Gen 1 | Allocated |
|------------ |--------------------- |-------------:|-------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     41.45 ms |    195.78 ms |    10.73 ms |     6.196 ms |     34.84 ms |     35.26 ms |     35.68 ms |     44.76 ms |     53.83 ms | 24.1254 |   4000.0000 |         - |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  5,229.41 ms |  6,679.31 ms |   366.12 ms |   211.377 ms |  4,864.71 ms |  5,045.65 ms |  5,226.59 ms |  5,411.76 ms |  5,596.92 ms |  0.1912 | 288000.0000 |         - |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 27,081.73 ms | 37,621.54 ms | 2,062.16 ms | 1,190.591 ms | 25,159.85 ms | 25,992.51 ms | 26,825.16 ms | 28,042.67 ms | 29,260.17 ms |  0.0369 | 290000.0000 | 1000.0000 |  9,569 MB |
