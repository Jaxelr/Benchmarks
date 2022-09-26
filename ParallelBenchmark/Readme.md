# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |      Mean |    Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  9.789 μs | 2.866 μs | 0.1571 μs | 0.0907 μs |  9.636 μs |  9.709 μs |  9.781 μs |  9.866 μs |  9.950 μs | 102,153.3 | 1.8005 | 0.0305 |   10.4 KB |
|      AsParallel | 16.146 μs | 7.246 μs | 0.3972 μs | 0.2293 μs | 15.876 μs | 15.918 μs | 15.961 μs | 16.282 μs | 16.602 μs |  61,933.5 | 1.5259 | 0.0305 |   9.16 KB |
