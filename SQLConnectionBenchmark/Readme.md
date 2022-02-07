# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method |     Mean |       Error |    StdDev |   Median | Allocated |
|---------------------- |---------:|------------:|----------:|---------:|----------:|
|    WithUsingExecution | 311.1 μs |    294.2 μs |  16.13 μs | 317.6 μs |     10 KB |
| WithoutUsingExecution | 813.1 μs | 13,622.9 μs | 746.72 μs | 382.3 μs |      8 KB |
