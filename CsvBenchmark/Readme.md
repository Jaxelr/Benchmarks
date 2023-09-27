# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     49.07 ms |    116.74 ms |     6.399 ms |     3.694 ms |     45.27 ms |     56.45 ms | 20.3801 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,758.07 ms |  6,163.45 ms |   337.839 ms |   195.052 ms |  3,496.79 ms |  4,139.58 ms |  0.2661 | 288000.0000 |         - |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 29,455.44 ms | 33,355.75 ms | 1,828.341 ms | 1,055.593 ms | 27,529.48 ms | 31,167.32 ms |  0.0339 | 292000.0000 | 3000.0000 | 1000.0000 | 9568.94 MB |
