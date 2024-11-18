# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]  : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-----------:|----------:|
| Increment            | 0.0008 ns | 0.0004 ns | 0.0023 ns | 0.0001 ns | 0.0000 ns | 0.0120 ns | 1,178,443,122,813.3 |          - |         - |
| IncrementInterlocked | 3.1491 ns | 0.0064 ns | 0.0316 ns | 0.0019 ns | 3.1064 ns | 3.3073 ns |       317,549,688.2 |          - |         - |
