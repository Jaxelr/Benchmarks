# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 4.448 μs | 5.216 μs | 0.2859 μs | 0.1651 μs | 4.245 μs | 4.775 μs | 224,828.4 | 1.7700 | 0.0305 |  10.28 KB |
| AsParallel      | 6.963 μs | 3.021 μs | 0.1656 μs | 0.0956 μs | 6.778 μs | 7.099 μs | 143,620.6 | 1.5106 | 0.0305 |   9.13 KB |
