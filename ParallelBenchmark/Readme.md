# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 3.984 μs | 8.463 μs | 0.4639 μs | 0.2678 μs | 3.639 μs | 4.511 μs | 251,033.5 | 1.8005 | 0.0305 |  10.46 KB |
| AsParallel      | 6.535 μs | 2.222 μs | 0.1218 μs | 0.0703 μs | 6.434 μs | 6.670 μs | 153,030.6 | 1.5106 | 0.0305 |   9.13 KB |
