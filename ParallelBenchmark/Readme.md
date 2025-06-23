# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean      | Error    | StdDev    | StdErr    | Min       | Max       | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  9.216 μs | 3.205 μs | 0.1757 μs | 0.1014 μs |  9.033 μs |  9.384 μs | 108,507.9 | 1.7090 | 0.0305 |  10.02 KB |
| AsParallel      | 15.042 μs | 7.348 μs | 0.4028 μs | 0.2325 μs | 14.807 μs | 15.507 μs |  66,480.8 | 1.4954 | 0.0305 |   9.13 KB |
