# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |      Op/s |  Gen 0 |  Gen 1 | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.020 μs | 1.152 μs | 0.0632 μs | 0.0365 μs | 4.975 μs | 4.984 μs | 4.994 μs | 5.043 μs | 5.093 μs | 199,183.5 | 1.9531 | 0.0381 |     11 KB |
|      AsParallel | 7.679 μs | 1.403 μs | 0.0769 μs | 0.0444 μs | 7.630 μs | 7.634 μs | 7.639 μs | 7.703 μs | 7.767 μs | 130,231.4 | 1.5259 | 0.0305 |      9 KB |
