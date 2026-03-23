# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.558 μs |   0.3299 μs | 0.0181 μs | 0.0104 μs |   2.547 μs |   2.579 μs | 390,952.1 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   2.959 μs |   0.2623 μs | 0.0144 μs | 0.0083 μs |   2.946 μs |   2.974 μs | 338,000.9 |  1.16 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.574 μs |   0.5605 μs | 0.0307 μs | 0.0177 μs |  20.547 μs |  20.607 μs |  48,604.2 |  8.04 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.278 μs |   0.2371 μs | 0.0130 μs | 0.0075 μs |  21.264 μs |  21.289 μs |  46,997.1 |  8.32 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.537 μs |   0.6985 μs | 0.0383 μs | 0.0221 μs |  24.505 μs |  24.579 μs |  40,755.4 |  9.59 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  25.735 μs |   7.1271 μs | 0.3907 μs | 0.2255 μs |  25.417 μs |  26.171 μs |  38,857.6 | 10.06 |         - |          NA |
|                               |           |            |            |             |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  29.435 μs |   0.2673 μs | 0.0147 μs | 0.0085 μs |  29.420 μs |  29.450 μs |  33,973.7 |  0.98 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  30.176 μs |  15.3309 μs | 0.8403 μs | 0.4852 μs |  29.354 μs |  31.034 μs |  33,139.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.369 μs |   3.1252 μs | 0.1713 μs | 0.0989 μs | 205.218 μs | 205.555 μs |   4,869.3 |  6.81 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 218.606 μs | 103.4543 μs | 5.6707 μs | 3.2740 μs | 212.543 μs | 223.778 μs |   4,574.4 |  7.25 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.601 μs |   0.5267 μs | 0.0289 μs | 0.0167 μs | 245.575 μs | 245.632 μs |   4,071.6 |  8.14 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 246.416 μs |   5.9555 μs | 0.3264 μs | 0.1885 μs | 246.145 μs | 246.778 μs |   4,058.2 |  8.17 |         - |          NA |
