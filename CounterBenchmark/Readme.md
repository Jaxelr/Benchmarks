# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]  : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-----------:|----------:|
| Increment            | 0.0156 ns | 0.0037 ns | 0.0187 ns | 0.0011 ns | 0.0000 ns | 0.0946 ns | 64,021,657,121.5 |          - |         - |
| IncrementInterlocked | 3.4126 ns | 0.0107 ns | 0.0528 ns | 0.0032 ns | 3.3531 ns | 3.6255 ns |    293,035,508.7 |          - |         - |
