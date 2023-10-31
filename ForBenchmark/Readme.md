# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   3.210 μs |  0.5578 μs | 0.0306 μs | 0.0177 μs |   3.178 μs |   3.239 μs | 311,535.9 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.277 μs |  0.3288 μs | 0.0180 μs | 0.0104 μs |   3.261 μs |   3.296 μs | 305,110.7 |  1.02 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   6.624 μs |  1.9769 μs | 0.1084 μs | 0.0626 μs |   6.514 μs |   6.731 μs | 150,961.9 |  2.06 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   6.939 μs |  5.0457 μs | 0.2766 μs | 0.1597 μs |   6.702 μs |   7.243 μs | 144,112.5 |  2.16 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  33.220 μs | 10.2202 μs | 0.5602 μs | 0.3234 μs |  32.843 μs |  33.863 μs |  30,102.6 | 10.35 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  38.564 μs |  3.6591 μs | 0.2006 μs | 0.1158 μs |  38.393 μs |  38.784 μs |  25,931.2 | 12.02 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  32.042 μs | 11.2431 μs | 0.6163 μs | 0.3558 μs |  31.411 μs |  32.643 μs |  31,209.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.321 μs |  3.1825 μs | 0.1744 μs | 0.1007 μs |  32.141 μs |  32.489 μs |  30,939.4 |  1.01 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  67.058 μs | 33.3886 μs | 1.8301 μs | 1.0566 μs |  65.785 μs |  69.155 μs |  14,912.5 |  2.09 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  71.612 μs | 40.2026 μs | 2.2036 μs | 1.2723 μs |  69.846 μs |  74.081 μs |  13,964.1 |  2.24 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 335.590 μs | 59.4427 μs | 3.2583 μs | 1.8812 μs | 333.024 μs | 339.256 μs |   2,979.8 | 10.48 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 386.100 μs | 45.3526 μs | 2.4859 μs | 1.4353 μs | 383.519 μs | 388.478 μs |   2,590.0 | 12.05 |      56 B |          NA |
