# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-----------:|----------:|
| Increment            | 0.0082 ns | 0.0947 ns | 0.0052 ns | 0.0030 ns | 0.0024 ns | 0.0124 ns | 122,661,015,947.5 |          - |         - |
| IncrementInterlocked | 3.1089 ns | 0.2350 ns | 0.0129 ns | 0.0074 ns | 3.0995 ns | 3.1236 ns |     321,658,381.3 |          - |         - |
