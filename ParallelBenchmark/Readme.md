# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |    StdErr |      Min |      Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.046 μs | 2.146 μs | 0.1176 μs | 0.0679 μs | 4.964 μs | 5.180 μs | 198,195.9 | 1.9989 | 0.0381 |  11.38 KB |
|      AsParallel | 6.968 μs | 2.335 μs | 0.1280 μs | 0.0739 μs | 6.877 μs | 7.114 μs | 143,518.0 | 1.5259 | 0.0305 |   9.16 KB |
