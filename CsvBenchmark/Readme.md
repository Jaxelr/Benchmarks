# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |         Error |       StdDev |       StdErr |          Min |          Max |    Op/s |        Gen0 |      Gen1 |      Gen2 |  Allocated |
|------------ |--------------------- |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     46.46 ms |      23.49 ms |     1.288 ms |     0.743 ms |     44.98 ms |     47.29 ms | 21.5224 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,784.60 ms |   6,359.50 ms |   348.586 ms |   201.256 ms |  4,467.67 ms |  5,157.95 ms |  0.2090 | 291000.0000 | 3000.0000 | 1000.0000 | 2400.31 MB |
| GenerateCsv | Syste(...)mple] [55] | 20,952.52 ms | 128,249.29 ms | 7,029.776 ms | 4,058.643 ms | 12,851.31 ms | 25,445.38 ms |  0.0477 | 292000.0000 | 3000.0000 | 1000.0000 | 9568.94 MB |
