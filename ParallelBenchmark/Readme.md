# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.209 μs | 0.4098 μs | 0.0225 μs | 0.0130 μs | 5.196 μs | 5.235 μs | 191,961.9 | 1.9150 | 0.0305 |  10.93 KB |
|      AsParallel | 7.686 μs | 0.8063 μs | 0.0442 μs | 0.0255 μs | 7.642 μs | 7.730 μs | 130,100.5 | 1.5259 | 0.0305 |   9.16 KB |
