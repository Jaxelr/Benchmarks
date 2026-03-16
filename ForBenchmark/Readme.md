# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.200
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error     | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.946 μs | 0.0550 μs | 0.0030 μs | 0.0017 μs |   2.944 μs |   2.949 μs | 339,430.7 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.957 μs | 0.0643 μs | 0.0035 μs | 0.0020 μs |   2.954 μs |   2.961 μs | 338,175.0 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.590 μs | 0.5440 μs | 0.0298 μs | 0.0172 μs |  20.556 μs |  20.614 μs |  48,567.4 |  6.96 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.335 μs | 0.2467 μs | 0.0135 μs | 0.0078 μs |  21.324 μs |  21.350 μs |  46,870.6 |  7.22 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.503 μs | 0.7699 μs | 0.0422 μs | 0.0244 μs |  24.459 μs |  24.543 μs |  40,811.6 |  8.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.914 μs | 9.6650 μs | 0.5298 μs | 0.3059 μs |  24.563 μs |  25.523 μs |  40,138.2 |  8.43 |         - |          NA |
|                               |           |            |            |           |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.356 μs | 0.3454 μs | 0.0189 μs | 0.0109 μs |  29.341 μs |  29.377 μs |  34,064.9 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.364 μs | 0.2048 μs | 0.0112 μs | 0.0065 μs |  29.351 μs |  29.374 μs |  34,055.8 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.627 μs | 1.8885 μs | 0.1035 μs | 0.0598 μs | 205.545 μs | 205.743 μs |   4,863.2 |  7.00 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 212.842 μs | 1.9722 μs | 0.1081 μs | 0.0624 μs | 212.741 μs | 212.956 μs |   4,698.3 |  7.25 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 245.693 μs | 6.7885 μs | 0.3721 μs | 0.2148 μs | 245.450 μs | 246.122 μs |   4,070.1 |  8.37 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.737 μs | 4.3681 μs | 0.2394 μs | 0.1382 μs | 245.484 μs | 245.959 μs |   4,069.4 |  8.37 |         - |          NA |
