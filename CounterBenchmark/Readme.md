# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]  : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-----------:|----------:|
| Increment            | 0.0049 ns | 0.0017 ns | 0.0085 ns | 0.0005 ns | 0.0000 ns | 0.0427 ns | 205,165,608,454.8 |          - |         - |
| IncrementInterlocked | 3.5771 ns | 0.0387 ns | 0.1911 ns | 0.0116 ns | 3.3670 ns | 4.2813 ns |     279,555,474.1 |          - |         - |
