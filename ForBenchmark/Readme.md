# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.943 μs |   0.0462 μs | 0.0025 μs | 0.0015 μs |   2.941 μs |   2.946 μs | 339,744.3 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.947 μs |   0.0584 μs | 0.0032 μs | 0.0018 μs |   2.944 μs |   2.951 μs | 339,278.3 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.589 μs |   0.3935 μs | 0.0216 μs | 0.0125 μs |  20.573 μs |  20.614 μs |  48,568.7 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  22.044 μs |  14.0988 μs | 0.7728 μs | 0.4462 μs |  21.321 μs |  22.859 μs |  45,363.6 |  7.48 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.489 μs |   0.4493 μs | 0.0246 μs | 0.0142 μs |  24.473 μs |  24.517 μs |  40,834.7 |  8.31 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.505 μs |   0.8694 μs | 0.0477 μs | 0.0275 μs |  24.456 μs |  24.551 μs |  40,807.6 |  8.31 |         - |          NA |
|                               |           |            |            |             |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.364 μs |   1.0088 μs | 0.0553 μs | 0.0319 μs |  29.332 μs |  29.428 μs |  34,054.8 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.931 μs |  10.2424 μs | 0.5614 μs | 0.3241 μs |  29.384 μs |  30.506 μs |  33,410.4 |  1.02 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 183.777 μs | 146.2781 μs | 8.0180 μs | 4.6292 μs | 177.583 μs | 192.833 μs |   5,441.4 |  6.26 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 192.062 μs |  96.4215 μs | 5.2852 μs | 3.0514 μs | 188.490 μs | 198.134 μs |   5,206.6 |  6.54 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 211.626 μs |  24.8263 μs | 1.3608 μs | 0.7857 μs | 210.710 μs | 213.189 μs |   4,725.3 |  7.21 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 213.511 μs |  49.9128 μs | 2.7359 μs | 1.5796 μs | 211.283 μs | 216.565 μs |   4,683.6 |  7.27 |         - |          NA |
