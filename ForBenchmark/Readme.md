# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.812 μs |   2.4595 μs | 0.1348 μs | 0.0778 μs |   2.703 μs |   2.963 μs | 355,630.1 |  0.97 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.892 μs |   0.2808 μs | 0.0154 μs | 0.0089 μs |   2.877 μs |   2.907 μs | 345,803.4 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.578 μs |   5.8120 μs | 0.3186 μs | 0.1839 μs |  20.223 μs |  20.839 μs |  48,595.6 |  7.12 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.308 μs |   0.1955 μs | 0.0107 μs | 0.0062 μs |  21.296 μs |  21.316 μs |  46,930.8 |  7.37 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.555 μs |   0.3944 μs | 0.0216 μs | 0.0125 μs |  24.530 μs |  24.570 μs |  40,725.7 |  8.49 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.574 μs |   0.2852 μs | 0.0156 μs | 0.0090 μs |  24.557 μs |  24.587 μs |  40,693.9 |  8.50 |         - |          NA |
|                               |           |            |            |             |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.491 μs |   3.2656 μs | 0.1790 μs | 0.1033 μs |  29.383 μs |  29.698 μs |  33,908.6 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.982 μs |  18.3402 μs | 1.0053 μs | 0.5804 μs |  29.398 μs |  31.142 μs |  33,353.9 |  1.02 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 209.118 μs |  66.5497 μs | 3.6478 μs | 2.1061 μs | 205.528 μs | 212.821 μs |   4,782.0 |  7.09 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 212.766 μs |   1.5680 μs | 0.0859 μs | 0.0496 μs | 212.669 μs | 212.834 μs |   4,700.0 |  7.21 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.749 μs |   5.8928 μs | 0.3230 μs | 0.1865 μs | 245.385 μs | 246.003 μs |   4,069.2 |  8.33 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 250.625 μs | 147.6019 μs | 8.0906 μs | 4.6711 μs | 245.907 μs | 259.967 μs |   3,990.0 |  8.50 |         - |          NA |
