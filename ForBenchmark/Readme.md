# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.202
  [Host]   : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.943 μs |  0.0286 μs | 0.0016 μs | 0.0009 μs |   2.942 μs |   2.945 μs | 339,757.8 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.953 μs |  0.1148 μs | 0.0063 μs | 0.0036 μs |   2.947 μs |   2.959 μs | 338,658.5 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.574 μs |  0.0180 μs | 0.0010 μs | 0.0006 μs |  20.573 μs |  20.575 μs |  48,604.2 |  6.97 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  23.582 μs | 13.2663 μs | 0.7272 μs | 0.4198 μs |  22.951 μs |  24.377 μs |  42,406.0 |  7.99 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  25.092 μs | 18.4946 μs | 1.0137 μs | 0.5853 μs |  24.498 μs |  26.262 μs |  39,853.9 |  8.50 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  25.606 μs | 24.6470 μs | 1.3510 μs | 0.7800 μs |  24.378 μs |  27.053 μs |  39,053.1 |  8.67 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.362 μs |  0.4280 μs | 0.0235 μs | 0.0135 μs |  29.337 μs |  29.384 μs |  34,057.6 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.376 μs |  0.4502 μs | 0.0247 μs | 0.0142 μs |  29.349 μs |  29.397 μs |  34,041.3 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.668 μs |  1.2699 μs | 0.0696 μs | 0.0402 μs | 205.615 μs | 205.747 μs |   4,862.2 |  7.00 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 213.369 μs |  2.4912 μs | 0.1365 μs | 0.0788 μs | 213.213 μs | 213.468 μs |   4,686.7 |  7.27 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.446 μs |  0.9391 μs | 0.0515 μs | 0.0297 μs | 245.388 μs | 245.487 μs |   4,074.2 |  8.36 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 245.667 μs |  6.7135 μs | 0.3680 μs | 0.2125 μs | 245.372 μs | 246.079 μs |   4,070.5 |  8.37 |         - |          NA |
