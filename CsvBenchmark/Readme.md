# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |         Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     86.32 ms |     126.91 ms |     6.957 ms |     4.016 ms |     82.18 ms |     94.35 ms | 11.5848 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,787.97 ms |  14,390.51 ms |   788.792 ms |   455.410 ms |  4,239.33 ms |  5,691.93 ms |  0.2089 | 288000.0000 |         - |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 26,740.53 ms | 166,861.13 ms | 9,146.222 ms | 5,280.573 ms | 16,556.39 ms | 34,254.53 ms |  0.0374 | 292000.0000 | 3000.0000 | 1000.0000 | 9568.94 MB |
