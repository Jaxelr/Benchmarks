# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev   | StdErr   | Min      | Max      | Op/s     | Gen0   | Gen1   | Allocated |
|---------------- |---------:|----------:|---------:|---------:|---------:|---------:|---------:|-------:|-------:|----------:|
| ParallelForEach | 13.14 μs |  3.697 μs | 0.203 μs | 0.117 μs | 12.97 μs | 13.36 μs | 76,122.6 | 1.7700 | 0.0305 |  10.32 KB |
| AsParallel      | 18.73 μs | 11.894 μs | 0.652 μs | 0.376 μs | 17.99 μs | 19.19 μs | 53,385.0 | 1.5259 | 0.0305 |   9.16 KB |
