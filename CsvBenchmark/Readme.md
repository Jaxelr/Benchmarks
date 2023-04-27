# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     33.78 ms |     71.73 ms |     3.932 ms |     2.270 ms |     30.25 ms |     38.01 ms | 29.6067 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,609.23 ms |  4,468.49 ms |   244.933 ms |   141.412 ms |  4,399.58 ms |  4,878.46 ms |  0.2170 | 290000.0000 | 2000.0000 |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 38,278.90 ms | 80,406.74 ms | 4,407.365 ms | 2,544.593 ms | 33,490.46 ms | 42,165.78 ms |  0.0261 | 292000.0000 | 3000.0000 | 1000.0000 | 9568.94 MB |
