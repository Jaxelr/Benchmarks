# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error     | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.953 μs | 0.0714 μs | 0.0039 μs | 0.0023 μs |   2.949 μs |   2.957 μs | 338,591.2 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.965 μs | 0.0669 μs | 0.0037 μs | 0.0021 μs |   2.961 μs |   2.968 μs | 337,296.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.660 μs | 0.5064 μs | 0.0278 μs | 0.0160 μs |  20.635 μs |  20.689 μs |  48,403.5 |  6.97 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.423 μs | 0.4139 μs | 0.0227 μs | 0.0131 μs |  21.401 μs |  21.447 μs |  46,678.6 |  7.23 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.498 μs | 1.0950 μs | 0.0600 μs | 0.0347 μs |  24.434 μs |  24.553 μs |  40,819.2 |  8.26 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.590 μs | 0.8207 μs | 0.0450 μs | 0.0260 μs |  24.542 μs |  24.630 μs |  40,666.1 |  8.29 |         - |          NA |
|                               |           |            |            |           |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.400 μs | 0.4196 μs | 0.0230 μs | 0.0133 μs |  29.374 μs |  29.415 μs |  34,013.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.428 μs | 0.3069 μs | 0.0168 μs | 0.0097 μs |  29.413 μs |  29.446 μs |  33,981.1 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 206.121 μs | 1.3179 μs | 0.0722 μs | 0.0417 μs | 206.042 μs | 206.185 μs |   4,851.5 |  7.01 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 213.415 μs | 3.8837 μs | 0.2129 μs | 0.1229 μs | 213.291 μs | 213.661 μs |   4,685.7 |  7.26 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 246.011 μs | 2.1477 μs | 0.1177 μs | 0.0680 μs | 245.891 μs | 246.127 μs |   4,064.9 |  8.37 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 246.088 μs | 7.0267 μs | 0.3852 μs | 0.2224 μs | 245.818 μs | 246.529 μs |   4,063.6 |  8.37 |         - |          NA |
