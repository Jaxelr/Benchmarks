# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                        | Increment | Iterations | Mean       | Error     | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.946 μs | 0.0158 μs | 0.0009 μs | 0.0005 μs |   2.945 μs |   2.947 μs | 339,386.6 |  0.99 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.963 μs | 0.0303 μs | 0.0017 μs | 0.0010 μs |   2.962 μs |   2.965 μs | 337,440.4 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.588 μs | 0.2580 μs | 0.0141 μs | 0.0082 μs |  20.578 μs |  20.604 μs |  48,572.1 |  6.95 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  21.329 μs | 0.3164 μs | 0.0173 μs | 0.0100 μs |  21.310 μs |  21.343 μs |  46,883.9 |  7.20 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.485 μs | 0.0596 μs | 0.0033 μs | 0.0019 μs |  24.483 μs |  24.488 μs |  40,842.0 |  8.26 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  24.529 μs | 1.0996 μs | 0.0603 μs | 0.0348 μs |  24.461 μs |  24.577 μs |  40,768.0 |  8.28 |         - |          NA |
|                               |           |            |            |           |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.402 μs | 0.2227 μs | 0.0122 μs | 0.0070 μs |  29.395 μs |  29.416 μs |  34,011.1 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  29.404 μs | 0.3856 μs | 0.0211 μs | 0.0122 μs |  29.382 μs |  29.424 μs |  34,009.0 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 205.645 μs | 2.4237 μs | 0.1328 μs | 0.0767 μs | 205.511 μs | 205.776 μs |   4,862.8 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 212.890 μs | 1.9146 μs | 0.1049 μs | 0.0606 μs | 212.775 μs | 212.980 μs |   4,697.3 |  7.24 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 245.897 μs | 0.4033 μs | 0.0221 μs | 0.0128 μs | 245.872 μs | 245.913 μs |   4,066.7 |  8.36 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 246.252 μs | 4.7826 μs | 0.2622 μs | 0.1514 μs | 245.995 μs | 246.519 μs |   4,060.9 |  8.38 |         - |          NA |
