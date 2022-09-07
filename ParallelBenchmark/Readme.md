# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |      Mean |      Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s |  Gen 0 |  Gen 1 | Allocated |
|---------------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  7.978 μs | 11.8781 μs | 0.6511 μs | 0.3759 μs |  7.515 μs |  7.606 μs |  7.696 μs |  8.209 μs |  8.722 μs | 125,346.0 | 1.8921 | 0.0305 |     11 KB |
|      AsParallel | 12.320 μs |  0.7518 μs | 0.0412 μs | 0.0238 μs | 12.287 μs | 12.297 μs | 12.308 μs | 12.337 μs | 12.366 μs |  81,166.4 | 1.5259 | 0.0305 |      9 KB |
