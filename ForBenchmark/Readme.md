# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]   : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error     | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.724 μs |  1.754 μs | 0.0961 μs | 0.0555 μs |   2.615 μs |   2.797 μs | 367,049.0 |  0.97 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.801 μs |  1.510 μs | 0.0828 μs | 0.0478 μs |   2.725 μs |   2.889 μs | 356,988.1 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  18.664 μs |  6.168 μs | 0.3381 μs | 0.1952 μs |  18.385 μs |  19.040 μs |  53,579.6 |  6.67 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  18.863 μs |  2.563 μs | 0.1405 μs | 0.0811 μs |  18.702 μs |  18.957 μs |  53,013.0 |  6.74 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  21.903 μs |  5.224 μs | 0.2863 μs | 0.1653 μs |  21.602 μs |  22.172 μs |  45,656.2 |  7.82 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  21.993 μs | 12.229 μs | 0.6703 μs | 0.3870 μs |  21.592 μs |  22.767 μs |  45,468.6 |  7.86 |         - |          NA |
|                               |           |            |            |           |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  25.963 μs |  3.940 μs | 0.2160 μs | 0.1247 μs |  25.719 μs |  26.130 μs |  38,516.7 |  0.92 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  28.319 μs | 21.133 μs | 1.1584 μs | 0.6688 μs |  27.115 μs |  29.426 μs |  35,312.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 191.958 μs | 73.981 μs | 4.0552 μs | 2.3413 μs | 187.451 μs | 195.312 μs |   5,209.5 |  6.79 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 193.041 μs | 93.997 μs | 5.1523 μs | 2.9747 μs | 187.125 μs | 196.539 μs |   5,180.2 |  6.82 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 215.031 μs | 32.015 μs | 1.7549 μs | 1.0132 μs | 213.919 μs | 217.054 μs |   4,650.5 |  7.60 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 220.158 μs | 69.045 μs | 3.7846 μs | 2.1850 μs | 216.137 μs | 223.651 μs |   4,542.2 |  7.78 |         - |          NA |
