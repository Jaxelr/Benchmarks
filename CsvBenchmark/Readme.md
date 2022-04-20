# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |         Error |        StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |    Op/s |       Gen 0 |      Gen 1 |     Gen 2 | Allocated |
|------------ |--------------------- |-------------:|--------------:|--------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|-----------:|----------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     58.24 ms |      85.20 ms |      4.670 ms |     2.696 ms |     53.96 ms |     55.75 ms |     57.53 ms |     60.37 ms |     63.22 ms | 17.1711 |   6000.0000 |          - |         - |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,186.35 ms |   5,656.01 ms |    310.025 ms |   178.993 ms |  3,901.58 ms |  4,021.22 ms |  4,140.87 ms |  4,328.73 ms |  4,516.60 ms |  0.2389 | 431000.0000 |          - |         - |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 72,348.00 ms | 206,207.12 ms | 11,302.908 ms | 6,525.737 ms | 61,521.64 ms | 66,485.14 ms | 71,448.64 ms | 77,761.18 ms | 84,073.72 ms |  0.0138 | 461000.0000 | 30000.0000 | 2000.0000 |  9,569 MB |
