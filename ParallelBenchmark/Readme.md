# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  7.483 μs | 0.7166 μs | 0.0393 μs | 0.0227 μs |  7.451 μs |  7.527 μs | 133,644.7 | 1.8768 | 0.0305 |  10.83 KB |
| AsParallel      | 11.885 μs | 4.8125 μs | 0.2638 μs | 0.1523 μs | 11.657 μs | 12.174 μs |  84,139.2 | 1.5259 | 0.0305 |   9.16 KB |
