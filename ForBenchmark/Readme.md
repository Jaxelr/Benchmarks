# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.907 μs |   0.6267 μs |  0.0344 μs | 0.0198 μs |   2.874 μs |   2.943 μs | 343,950.3 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.909 μs |   0.0670 μs |  0.0037 μs | 0.0021 μs |   2.905 μs |   2.912 μs | 343,799.0 |  1.00 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  20.296 μs |   2.3925 μs |  0.1311 μs | 0.0757 μs |  20.175 μs |  20.435 μs |  49,271.9 |  6.98 |      56 B |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.900 μs |  17.7465 μs |  0.9727 μs | 0.5616 μs |  20.197 μs |  22.010 μs |  47,847.2 |  7.19 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  23.822 μs |  10.4897 μs |  0.5750 μs | 0.3320 μs |  23.167 μs |  24.240 μs |  41,977.4 |  8.19 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.053 μs |  13.7800 μs |  0.7553 μs | 0.4361 μs |  23.391 μs |  24.876 μs |  41,575.0 |  8.27 |         - |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  26.402 μs |  10.5158 μs |  0.5764 μs | 0.3328 μs |  26.045 μs |  27.067 μs |  37,876.5 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  27.486 μs |  14.2621 μs |  0.7818 μs | 0.4513 μs |  26.590 μs |  28.029 μs |  36,382.3 |  1.04 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 190.959 μs |  73.6421 μs |  4.0366 μs | 2.3305 μs | 186.347 μs | 193.848 μs |   5,236.7 |  7.24 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 202.445 μs |  66.6976 μs |  3.6559 μs | 2.1107 μs | 199.332 μs | 206.471 μs |   4,939.6 |  7.67 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 236.035 μs | 253.0188 μs | 13.8688 μs | 8.0072 μs | 221.283 μs | 248.808 μs |   4,236.7 |  8.94 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 249.123 μs |  48.2129 μs |  2.6427 μs | 1.5258 μs | 247.413 μs | 252.167 μs |   4,014.1 |  9.44 |         - |          NA |
