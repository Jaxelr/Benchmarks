# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.925 μs |  1.8297 μs | 0.1003 μs | 0.0579 μs |   2.866 μs |   3.041 μs | 341,885.0 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   2.941 μs |  0.2926 μs | 0.0160 μs | 0.0093 μs |   2.925 μs |   2.957 μs | 340,063.4 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.657 μs |  2.1256 μs | 0.1165 μs | 0.0673 μs |  20.546 μs |  20.778 μs |  48,410.6 |  7.07 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.171 μs |  3.6462 μs | 0.1999 μs | 0.1154 μs |  20.945 μs |  21.324 μs |  47,234.2 |  7.24 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.532 μs |  0.4384 μs | 0.0240 μs | 0.0139 μs |  24.508 μs |  24.556 μs |  40,762.4 |  8.39 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.712 μs |  5.9604 μs | 0.3267 μs | 0.1886 μs |  24.466 μs |  25.082 μs |  40,466.7 |  8.46 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  29.386 μs |  0.4710 μs | 0.0258 μs | 0.0149 μs |  29.357 μs |  29.408 μs |  34,030.3 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  29.413 μs |  1.2386 μs | 0.0679 μs | 0.0392 μs |  29.370 μs |  29.491 μs |  33,999.1 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 206.059 μs | 16.6157 μs | 0.9108 μs | 0.5258 μs | 205.262 μs | 207.052 μs |   4,853.0 |  7.01 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 212.659 μs |  3.4697 μs | 0.1902 μs | 0.1098 μs | 212.503 μs | 212.871 μs |   4,702.4 |  7.23 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.262 μs |  6.6327 μs | 0.3636 μs | 0.2099 μs | 245.009 μs | 245.678 μs |   4,077.3 |  8.34 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 245.600 μs |  4.2381 μs | 0.2323 μs | 0.1341 μs | 245.462 μs | 245.868 μs |   4,071.7 |  8.35 |         - |          NA |
