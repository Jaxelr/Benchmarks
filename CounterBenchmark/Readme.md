# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]  : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2256 ns | 0.0329 ns | 0.1698 ns | 0.0099 ns | 0.0000 ns | 0.8451 ns | 4,432,398,148.6 |          - |         - |
| IncrementInterlocked | 4.8835 ns | 0.3660 ns | 1.8849 ns | 0.1101 ns | 0.9581 ns | 9.8738 ns |   204,771,305.0 |          - |         - |
