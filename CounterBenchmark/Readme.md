# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]  : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.1146 ns | 0.0377 ns | 0.1921 ns | 0.0113 ns | 0.0000 ns | 0.6101 ns | 8,728,319,191.5 |          - |         - |
| IncrementInterlocked | 4.0679 ns | 0.1975 ns | 1.0079 ns | 0.0594 ns | 3.1327 ns | 7.6627 ns |   245,829,286.9 |          - |         - |
