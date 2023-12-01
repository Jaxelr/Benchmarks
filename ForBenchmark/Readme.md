# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   3.841 μs |   5.136 μs |  0.2815 μs |  0.1625 μs |   3.540 μs |   4.098 μs | 260,369.4 |  0.86 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   4.462 μs |   1.652 μs |  0.0906 μs |  0.0523 μs |   4.372 μs |   4.553 μs | 224,100.8 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   7.976 μs |  11.945 μs |  0.6547 μs |  0.3780 μs |   7.288 μs |   8.592 μs | 125,376.8 |  1.79 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  10.265 μs |  14.001 μs |  0.7674 μs |  0.4431 μs |   9.674 μs |  11.132 μs |  97,420.2 |  2.30 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  14.677 μs |  28.484 μs |  1.5613 μs |  0.9014 μs |  12.945 μs |  15.975 μs |  68,133.5 |  3.29 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  25.371 μs | 155.778 μs |  8.5387 μs |  4.9298 μs |  16.612 μs |  33.671 μs |  39,414.5 |  5.67 |         - |          NA |
|                               |           |            |            |            |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  59.028 μs |  19.745 μs |  1.0823 μs |  0.6249 μs |  57.840 μs |  59.959 μs |  16,941.2 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  65.950 μs |  33.536 μs |  1.8382 μs |  1.0613 μs |  64.250 μs |  67.900 μs |  15,163.1 |  1.12 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 159.064 μs | 549.131 μs | 30.0997 μs | 17.3781 μs | 139.157 μs | 193.691 μs |   6,286.8 |  2.70 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 172.176 μs | 372.778 μs | 20.4332 μs | 11.7971 μs | 155.535 μs | 194.982 μs |   5,808.0 |  2.92 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 262.383 μs | 331.469 μs | 18.1689 μs | 10.4898 μs | 243.006 μs | 279.036 μs |   3,811.2 |  4.44 |      56 B |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 379.513 μs | 110.364 μs |  6.0494 μs |  3.4926 μs | 372.935 μs | 384.837 μs |   2,635.0 |  6.43 |      40 B |          NA |
