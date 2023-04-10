# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |    StdErr |      Min |      Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.488 μs | 2.887 μs | 0.1582 μs | 0.0914 μs | 5.325 μs | 5.640 μs | 182,204.7 | 1.9913 | 0.0381 |  11.33 KB |
|      AsParallel | 7.727 μs | 1.865 μs | 0.1022 μs | 0.0590 μs | 7.661 μs | 7.845 μs | 129,419.0 | 1.5259 | 0.0305 |   9.16 KB |
