# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2361/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean      | Error    | StdDev    | StdErr    | Min       | Max       | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  8.182 μs | 2.685 μs | 0.1472 μs | 0.0850 μs |  8.018 μs |  8.304 μs | 122,219.9 | 1.8921 | 0.0305 |  10.84 KB |
| AsParallel      | 10.782 μs | 5.476 μs | 0.3002 μs | 0.1733 μs | 10.599 μs | 11.128 μs |  92,746.8 | 1.5259 | 0.0305 |   9.16 KB |
