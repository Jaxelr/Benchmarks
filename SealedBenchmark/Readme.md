# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 4.3674 ns | 9.9640 ns | 0.5462 ns | 0.3153 ns | 3.8954 ns | 4.9656 ns |     228,966,891.2 | 0.0038 |      24 B |
| Open_AddToArray   | 4.6313 ns | 4.7369 ns | 0.2596 ns | 0.1499 ns | 4.3440 ns | 4.8491 ns |     215,920,866.9 | 0.0038 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_Casting      | 0.0099 ns | 0.3116 ns | 0.0171 ns | 0.0099 ns | 0.0000 ns | 0.0296 ns | 101,398,434,651.2 |      - |         - |
| Sealed_Casting    | 0.5640 ns | 0.7697 ns | 0.0422 ns | 0.0244 ns | 0.5290 ns | 0.6109 ns |   1,773,006,672.3 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0018 ns | 0.0568 ns | 0.0031 ns | 0.0018 ns | 0.0000 ns | 0.0054 ns | 556,496,695,459.9 |      - |         - |
| Sealed_IntMethod  | 0.0023 ns | 0.0726 ns | 0.0040 ns | 0.0023 ns | 0.0000 ns | 0.0069 ns | 435,418,420,113.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 3.2211 ns | 0.8270 ns | 0.0453 ns | 0.0262 ns | 3.1889 ns | 3.2729 ns |     310,454,428.0 |      - |         - |
| Open_ToString     | 3.2309 ns | 0.8443 ns | 0.0463 ns | 0.0267 ns | 3.1776 ns | 3.2608 ns |     309,507,254.4 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_VoidMethod   | 0.0024 ns | 0.0704 ns | 0.0039 ns | 0.0022 ns | 0.0000 ns | 0.0068 ns | 417,863,412,204.2 |      - |         - |
