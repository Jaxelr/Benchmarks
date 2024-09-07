# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean      | Error    | StdDev    | StdErr    | Min       | Max       | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  7.518 μs | 1.956 μs | 0.1072 μs | 0.0619 μs |  7.413 μs |  7.628 μs | 133,005.8 | 1.8311 | 0.0305 |   10.6 KB |
| AsParallel      | 12.001 μs | 5.103 μs | 0.2797 μs | 0.1615 μs | 11.754 μs | 12.305 μs |  83,323.9 | 1.5259 | 0.0305 |   9.16 KB |
