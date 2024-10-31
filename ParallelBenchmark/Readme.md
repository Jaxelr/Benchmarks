# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.806 μs | 12.365 μs | 0.6778 μs | 0.3913 μs | 5.110 μs |  6.464 μs | 172,234.5 | 1.7548 | 0.0305 |  10.15 KB |
| AsParallel      | 9.731 μs | 29.234 μs | 1.6024 μs | 0.9251 μs | 8.040 μs | 11.227 μs | 102,759.9 | 1.5259 | 0.0305 |   9.16 KB |
