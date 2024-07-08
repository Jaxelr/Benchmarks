# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3810/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2690 ns |  0.7429 ns | 0.0407 ns | 0.0235 ns | 0.2348 ns | 0.3140 ns | 3,717,453,465.3 |          - |         - |
| IncrementInterlocked | 6.5051 ns | 33.6451 ns | 1.8442 ns | 1.0647 ns | 5.3311 ns | 8.6307 ns |   153,725,692.6 |          - |         - |
