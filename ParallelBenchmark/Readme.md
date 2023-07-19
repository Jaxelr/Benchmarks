# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |    StdDev |    StdErr |      Min |      Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 4.963 μs | 6.013 μs | 0.3296 μs | 0.1903 μs | 4.705 μs | 5.334 μs | 201,492.9 | 1.9836 | 0.0381 |  11.31 KB |
|      AsParallel | 7.104 μs | 5.079 μs | 0.2784 μs | 0.1607 μs | 6.783 μs | 7.277 μs | 140,767.5 | 1.5259 | 0.0305 |   9.16 KB |
