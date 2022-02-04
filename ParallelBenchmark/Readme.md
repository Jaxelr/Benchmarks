# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
|---------------- |---------:|----------:|----------:|-------:|----------:|
| ParallelForEach | 5.343 μs | 0.5951 μs | 0.0326 μs | 2.9831 |     11 KB |
|      AsParallel | 8.885 μs | 3.1239 μs | 0.1712 μs | 2.2964 |      9 KB |

