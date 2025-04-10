# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]  : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-----------:|----------:|
| Increment            | 0.0631 ns | 0.0115 ns | 0.0576 ns | 0.0034 ns | 0.0000 ns | 0.2041 ns | 15,855,205,371.3 |          - |         - |
| IncrementInterlocked | 3.4528 ns | 0.0165 ns | 0.0841 ns | 0.0050 ns | 3.3590 ns | 3.8873 ns |    289,621,147.9 |          - |         - |
