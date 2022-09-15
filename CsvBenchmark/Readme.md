# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |     StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |  Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     24.59 ms |     36.56 ms |     2.004 ms |   1.157 ms |     22.54 ms |     26.54 ms | 40.6656 |   4000.0000 |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,742.74 ms |  6,149.89 ms |   337.096 ms | 194.623 ms |  2,398.30 ms |  3,071.97 ms |  0.3646 | 288000.0000 |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 19,014.40 ms | 20,128.01 ms | 1,103.284 ms | 636.981 ms | 18,327.96 ms | 20,287.04 ms |  0.0526 | 295000.0000 | 6000.0000 | 9568.94 MB |
