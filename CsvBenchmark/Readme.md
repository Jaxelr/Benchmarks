# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |         Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     53.11 ms |     154.09 ms |     8.446 ms |     4.876 ms |     43.50 ms |     59.33 ms | 18.8283 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,061.72 ms |   4,942.52 ms |   270.916 ms |   156.414 ms |  2,864.51 ms |  3,370.63 ms |  0.3266 | 289000.0000 | 2000.0000 | 1000.0000 | 2400.31 MB |
| GenerateCsv | Syste(...)mple] [55] | 46,363.39 ms | 178,448.77 ms | 9,781.379 ms | 5,647.282 ms | 35,500.66 ms | 54,473.60 ms |  0.0216 | 297000.0000 | 8000.0000 |         - | 9568.94 MB |
