# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 4.0394 ns |  5.8110 ns | 0.3185 ns | 0.1839 ns | 3.7397 ns | 4.3739 ns |     247,563,691.3 | 0.0038 |      24 B |
| Open_AddToArray   | 8.3092 ns | 20.2518 ns | 1.1101 ns | 0.6409 ns | 7.0988 ns | 9.2798 ns |     120,348,922.7 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                   |        |           |
| Open_Casting      | 0.0175 ns |  0.0536 ns | 0.0029 ns | 0.0017 ns | 0.0146 ns | 0.0204 ns |  57,004,768,740.7 |      - |         - |
| Sealed_Casting    | 0.6280 ns |  1.1204 ns | 0.0614 ns | 0.0355 ns | 0.5699 ns | 0.6923 ns |   1,592,432,885.2 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_IntMethod    | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Open_ToString     | 3.0759 ns |  1.1244 ns | 0.0616 ns | 0.0356 ns | 3.0098 ns | 3.1318 ns |     325,110,809.7 |      - |         - |
| Sealed_ToString   | 3.1809 ns |  2.0490 ns | 0.1123 ns | 0.0648 ns | 3.0792 ns | 3.3014 ns |     314,379,702.1 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_VoidMethod   | 0.0051 ns |  0.0809 ns | 0.0044 ns | 0.0026 ns | 0.0000 ns | 0.0083 ns | 197,647,871,001.0 |      - |         - |
