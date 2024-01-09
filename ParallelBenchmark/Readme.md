# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 5.032 μs | 4.655 μs | 0.2551 μs | 0.1473 μs | 4.750 μs | 5.246 μs | 198,730.1 | 1.9226 | 0.0305 |   11.1 KB |
| AsParallel      | 6.343 μs | 1.300 μs | 0.0713 μs | 0.0411 μs | 6.299 μs | 6.426 μs | 157,644.4 | 1.5259 | 0.0305 |   9.16 KB |
