# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]   : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  ShortRun : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |     StdDev |     StdErr |          Min |           Q1 |       Median |           Q3 |          Max |    Op/s |       Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     26.86 ms |     19.58 ms |   1.073 ms |   0.620 ms |     25.73 ms |     26.35 ms |     26.97 ms |     27.42 ms |     27.87 ms | 37.2299 |   4000.0000 | 1000.0000 |         - |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,749.92 ms | 11,542.22 ms | 632.668 ms | 365.271 ms |  2,241.51 ms |  2,395.66 ms |  2,549.80 ms |  3,004.13 ms |  3,458.45 ms |  0.3636 | 289000.0000 | 2000.0000 | 1000.0000 |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,930.42 ms |  5,747.56 ms | 315.043 ms | 181.890 ms | 11,572.25 ms | 11,813.32 ms | 12,054.40 ms | 12,109.51 ms | 12,164.61 ms |  0.0838 | 290000.0000 |         - |         - |  9,569 MB |
