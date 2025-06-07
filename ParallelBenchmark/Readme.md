# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 4.298 μs | 0.3231 μs | 0.0177 μs | 0.0102 μs | 4.282 μs | 4.317 μs | 232,657.0 | 1.7853 | 0.0305 |  10.38 KB |
| AsParallel      | 7.488 μs | 3.4958 μs | 0.1916 μs | 0.1106 μs | 7.331 μs | 7.701 μs | 133,555.1 | 1.5106 | 0.0305 |   9.13 KB |
