# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.804 μs |  1.0850 μs | 0.0595 μs | 0.0343 μs |   2.755 μs |   2.870 μs | 356,638.0 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   2.850 μs |  0.3581 μs | 0.0196 μs | 0.0113 μs |   2.839 μs |   2.873 μs | 350,827.1 |  1.02 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.158 μs |  1.7329 μs | 0.0950 μs | 0.0548 μs |  20.091 μs |  20.267 μs |  49,608.1 |  7.19 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  20.724 μs |  1.8629 μs | 0.1021 μs | 0.0590 μs |  20.655 μs |  20.841 μs |  48,253.9 |  7.39 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  23.819 μs |  4.7152 μs | 0.2585 μs | 0.1492 μs |  23.567 μs |  24.084 μs |  41,982.7 |  8.50 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  23.830 μs | 16.6372 μs | 0.9119 μs | 0.5265 μs |  22.873 μs |  24.688 μs |  41,963.1 |  8.50 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  26.804 μs | 15.6633 μs | 0.8586 μs | 0.4957 μs |  25.963 μs |  27.679 μs |  37,307.5 |  0.93 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  28.917 μs |  3.4978 μs | 0.1917 μs | 0.1107 μs |  28.698 μs |  29.052 μs |  34,581.7 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 191.401 μs | 87.7913 μs | 4.8121 μs | 2.7783 μs | 185.848 μs | 194.344 μs |   5,224.6 |  6.62 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 213.226 μs | 40.5686 μs | 2.2237 μs | 1.2839 μs | 211.665 μs | 215.772 μs |   4,689.9 |  7.37 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 233.613 μs | 22.7511 μs | 1.2471 μs | 0.7200 μs | 232.553 μs | 234.987 μs |   4,280.6 |  8.08 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 242.814 μs | 61.1291 μs | 3.3507 μs | 1.9345 μs | 239.192 μs | 245.804 μs |   4,118.4 |  8.40 |         - |          NA |
