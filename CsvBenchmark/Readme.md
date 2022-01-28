# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples |         Mean |        Error |       StdDev |       Gen 0 |      Gen 1 |     Gen 2 | Allocated |
|------------ |--------------------- |-------------:|-------------:|-------------:|------------:|-----------:|----------:|----------:|
| GenerateCsv | Syste(...)mple] [55] |     44.63 ms |    175.93 ms |     9.643 ms |   6000.0000 |          - |         - |     25 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,280.15 ms |  8,867.60 ms |   486.063 ms | 431000.0000 |          - |         - |  2,400 MB |
| GenerateCsv | Syste(...)mple] [55] | 42,916.36 ms | 26,969.17 ms | 1,478.271 ms | 449000.0000 | 17000.0000 | 1000.0000 |  9,569 MB |
