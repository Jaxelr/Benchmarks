# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]   : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  ShortRun : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |      Op/s |  Gen 0 |  Gen 1 | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 4.933 μs | 1.532 μs | 0.0840 μs | 0.0485 μs | 4.837 μs | 4.903 μs | 4.970 μs | 4.981 μs | 4.992 μs | 202,725.4 | 1.9455 | 0.0305 |     11 KB |
|      AsParallel | 7.461 μs | 1.164 μs | 0.0638 μs | 0.0368 μs | 7.407 μs | 7.426 μs | 7.445 μs | 7.488 μs | 7.532 μs | 134,027.3 | 1.5259 | 0.0305 |      9 KB |
