# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.600 μs |  0.6998 μs | 0.0384 μs | 0.0221 μs |   2.565 μs |   2.641 μs | 384,663.6 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   2.633 μs |  1.6510 μs | 0.0905 μs | 0.0522 μs |   2.556 μs |   2.733 μs | 379,794.9 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.661 μs |  0.1566 μs | 0.0086 μs | 0.0050 μs |  20.652 μs |  20.670 μs |  48,400.0 |  7.95 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.470 μs |  1.4898 μs | 0.0817 μs | 0.0471 μs |  21.396 μs |  21.557 μs |  46,577.6 |  8.26 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.572 μs |  0.9896 μs | 0.0542 μs | 0.0313 μs |  24.518 μs |  24.626 μs |  40,697.0 |  9.45 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.704 μs |  3.4440 μs | 0.1888 μs | 0.1090 μs |  24.490 μs |  24.844 μs |  40,478.6 |  9.50 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.408 μs |  0.3461 μs | 0.0190 μs | 0.0110 μs |  29.392 μs |  29.429 μs |  34,003.9 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.576 μs |  0.8077 μs | 0.0443 μs | 0.0256 μs |  29.525 μs |  29.602 μs |  33,811.5 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 206.001 μs |  2.3220 μs | 0.1273 μs | 0.0735 μs | 205.871 μs | 206.125 μs |   4,854.4 |  7.00 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 214.213 μs |  6.1820 μs | 0.3389 μs | 0.1956 μs | 213.969 μs | 214.600 μs |   4,668.3 |  7.28 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 246.278 μs |  2.0731 μs | 0.1136 μs | 0.0656 μs | 246.160 μs | 246.387 μs |   4,060.5 |  8.37 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 247.150 μs | 18.3399 μs | 1.0053 μs | 0.5804 μs | 246.128 μs | 248.137 μs |   4,046.1 |  8.40 |         - |          NA |
