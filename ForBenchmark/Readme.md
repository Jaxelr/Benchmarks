# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6584)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.948 μs |  0.3060 μs | 0.0168 μs | 0.0097 μs |   2.930 μs |   2.963 μs | 339,250.8 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   2.984 μs |  1.7902 μs | 0.0981 μs | 0.0567 μs |   2.903 μs |   3.093 μs | 335,153.7 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  21.388 μs |  6.6937 μs | 0.3669 μs | 0.2118 μs |  21.037 μs |  21.769 μs |  46,754.8 |  7.26 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  22.449 μs | 23.3107 μs | 1.2777 μs | 0.7377 μs |  21.681 μs |  23.924 μs |  44,544.7 |  7.62 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  22.838 μs | 15.4371 μs | 0.8462 μs | 0.4885 μs |  22.203 μs |  23.799 μs |  43,786.8 |  7.75 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  26.238 μs | 19.4055 μs | 1.0637 μs | 0.6141 μs |  25.466 μs |  27.451 μs |  38,113.1 |  8.90 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  25.493 μs |  4.8467 μs | 0.2657 μs | 0.1534 μs |  25.282 μs |  25.791 μs |  39,227.2 |  0.99 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  25.787 μs |  5.6475 μs | 0.3096 μs | 0.1787 μs |  25.439 μs |  26.031 μs |  38,778.7 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 177.810 μs | 16.1051 μs | 0.8828 μs | 0.5097 μs | 176.924 μs | 178.690 μs |   5,624.0 |  6.90 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 186.816 μs | 46.0532 μs | 2.5243 μs | 1.4574 μs | 184.658 μs | 189.592 μs |   5,352.9 |  7.25 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 211.103 μs | 56.1466 μs | 3.0776 μs | 1.7768 μs | 208.709 μs | 214.574 μs |   4,737.0 |  8.19 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 213.746 μs | 69.8768 μs | 3.8302 μs | 2.2114 μs | 209.837 μs | 217.492 μs |   4,678.5 |  8.29 |         - |          NA |
