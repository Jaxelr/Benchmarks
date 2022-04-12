# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.201
  [Host]   : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  ShortRun : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |      Mean |    Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s |  Gen 0 | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| ParallelForEach |  7.570 μs | 8.413 μs | 0.4612 μs | 0.2663 μs |  7.182 μs |  7.315 μs |  7.448 μs |  7.764 μs |  8.080 μs | 132,105.6 | 2.9755 |     11 KB |
|      AsParallel | 10.262 μs | 5.183 μs | 0.2841 μs | 0.1640 μs | 10.037 μs | 10.102 μs | 10.167 μs | 10.374 μs | 10.581 μs |  97,447.3 | 2.3041 |      9 KB |
