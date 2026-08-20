# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.944 μs |  0.0623 μs | 0.0034 μs | 0.0020 μs |   2.941 μs |   2.948 μs | 339,688.5 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.946 μs |  0.0397 μs | 0.0022 μs | 0.0013 μs |   2.943 μs |   2.948 μs | 339,451.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.589 μs |  0.3401 μs | 0.0186 μs | 0.0108 μs |  20.572 μs |  20.609 μs |  48,569.1 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.296 μs |  0.4386 μs | 0.0240 μs | 0.0139 μs |  21.272 μs |  21.320 μs |  46,957.3 |  7.23 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.519 μs |  1.0240 μs | 0.0561 μs | 0.0324 μs |  24.466 μs |  24.578 μs |  40,784.2 |  8.32 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.529 μs |  0.3506 μs | 0.0192 μs | 0.0111 μs |  24.507 μs |  24.543 μs |  40,768.5 |  8.33 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  29.339 μs |  0.2709 μs | 0.0148 μs | 0.0086 μs |  29.327 μs |  29.355 μs |  34,084.5 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  29.385 μs |  0.4516 μs | 0.0248 μs | 0.0143 μs |  29.364 μs |  29.412 μs |  34,030.9 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.510 μs |  1.7183 μs | 0.0942 μs | 0.0544 μs | 205.446 μs | 205.618 μs |   4,865.9 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 212.925 μs |  3.3786 μs | 0.1852 μs | 0.1069 μs | 212.761 μs | 213.126 μs |   4,696.5 |  7.25 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 245.931 μs | 11.3206 μs | 0.6205 μs | 0.3583 μs | 245.310 μs | 246.551 μs |   4,066.2 |  8.37 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 245.978 μs |  4.1114 μs | 0.2254 μs | 0.1301 μs | 245.792 μs | 246.229 μs |   4,065.4 |  8.37 |         - |          NA |
