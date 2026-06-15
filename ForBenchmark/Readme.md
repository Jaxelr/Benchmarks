# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.947 μs |  0.0814 μs | 0.0045 μs | 0.0026 μs |   2.944 μs |   2.952 μs | 339,342.8 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.951 μs |  0.1199 μs | 0.0066 μs | 0.0038 μs |   2.946 μs |   2.958 μs | 338,890.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.610 μs |  0.5687 μs | 0.0312 μs | 0.0180 μs |  20.585 μs |  20.645 μs |  48,520.9 |  6.98 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.330 μs |  0.4353 μs | 0.0239 μs | 0.0138 μs |  21.311 μs |  21.357 μs |  46,882.1 |  7.23 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.545 μs |  0.6424 μs | 0.0352 μs | 0.0203 μs |  24.508 μs |  24.578 μs |  40,740.7 |  8.32 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.560 μs |  0.7671 μs | 0.0420 μs | 0.0243 μs |  24.521 μs |  24.604 μs |  40,716.8 |  8.32 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  29.379 μs |  0.2555 μs | 0.0140 μs | 0.0081 μs |  29.367 μs |  29.394 μs |  34,037.7 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  29.420 μs |  0.7085 μs | 0.0388 μs | 0.0224 μs |  29.378 μs |  29.454 μs |  33,990.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.628 μs |  1.1902 μs | 0.0652 μs | 0.0377 μs | 205.552 μs | 205.668 μs |   4,863.2 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 213.382 μs |  4.0183 μs | 0.2203 μs | 0.1272 μs | 213.237 μs | 213.635 μs |   4,686.4 |  7.25 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 246.186 μs |  6.1581 μs | 0.3375 μs | 0.1949 μs | 245.797 μs | 246.401 μs |   4,062.0 |  8.37 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 246.836 μs | 14.7098 μs | 0.8063 μs | 0.4655 μs | 246.290 μs | 247.762 μs |   4,051.3 |  8.39 |         - |          NA |
