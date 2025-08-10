# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   5.247 μs |  0.0411 μs | 0.0023 μs | 0.0013 μs |   5.246 μs |   5.250 μs | 190,572.7 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   5.254 μs |  0.0720 μs | 0.0039 μs | 0.0023 μs |   5.250 μs |   5.258 μs | 190,339.5 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  36.705 μs |  0.4467 μs | 0.0245 μs | 0.0141 μs |  36.677 μs |  36.725 μs |  27,244.4 |  6.99 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  38.058 μs |  1.0460 μs | 0.0573 μs | 0.0331 μs |  38.007 μs |  38.120 μs |  26,275.4 |  7.24 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  43.346 μs |  2.9389 μs | 0.1611 μs | 0.0930 μs |  43.195 μs |  43.515 μs |  23,070.4 |  8.25 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  43.421 μs |  2.8077 μs | 0.1539 μs | 0.0889 μs |  43.272 μs |  43.579 μs |  23,030.1 |  8.26 |         - |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  52.298 μs |  0.8632 μs | 0.0473 μs | 0.0273 μs |  52.259 μs |  52.351 μs |  19,121.3 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  52.309 μs |  0.8123 μs | 0.0445 μs | 0.0257 μs |  52.258 μs |  52.341 μs |  19,117.1 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 366.201 μs |  3.8838 μs | 0.2129 μs | 0.1229 μs | 366.061 μs | 366.446 μs |   2,730.7 |  7.00 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 379.655 μs |  1.7597 μs | 0.0965 μs | 0.0557 μs | 379.545 μs | 379.723 μs |   2,634.0 |  7.26 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 434.118 μs |  8.7677 μs | 0.4806 μs | 0.2775 μs | 433.797 μs | 434.671 μs |   2,303.5 |  8.30 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 435.515 μs | 22.9130 μs | 1.2559 μs | 0.7251 μs | 434.203 μs | 436.707 μs |   2,296.1 |  8.33 |         - |          NA |
