# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     35.52 ms |     49.59 ms |     2.718 ms |     1.569 ms |     33.05 ms |     38.44 ms | 28.1503 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,932.02 ms | 14,056.35 ms |   770.476 ms |   444.834 ms |  4,061.03 ms |  5,524.58 ms |  0.2028 | 289000.0000 | 1000.0000 |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 52,932.74 ms | 55,766.90 ms | 3,056.772 ms | 1,764.828 ms | 49,522.71 ms | 55,426.80 ms |  0.0189 | 295000.0000 | 7000.0000 | 1000.0000 | 9568.94 MB |
