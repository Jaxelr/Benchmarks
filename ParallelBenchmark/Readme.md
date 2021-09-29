# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1237 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.401
  [Host]   : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT
  ShortRun : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |  Gen 0 | Allocated |
|---------------- |---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 5.660 μs | 1.313 μs | 0.0720 μs | 2.7771 |     11 KB |
|      AsParallel | 8.424 μs | 1.329 μs | 0.0729 μs | 2.3193 |      9 KB |
