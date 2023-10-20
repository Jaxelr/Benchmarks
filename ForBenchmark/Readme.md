# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean         | Error         | StdDev      | StdErr     | Min          | Max          | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-------------:|--------------:|------------:|-----------:|-------------:|-------------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |     4.352 μs |     0.7871 μs |   0.0431 μs |  0.0249 μs |     4.303 μs |     4.382 μs | 229,754.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |     4.452 μs |     0.7473 μs |   0.0410 μs |  0.0236 μs |     4.408 μs |     4.490 μs | 224,619.0 |  1.02 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |     9.245 μs |     5.7300 μs |   0.3141 μs |  0.1813 μs |     8.934 μs |     9.562 μs | 108,164.8 |  2.12 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |     9.266 μs |     9.5508 μs |   0.5235 μs |  0.3022 μs |     8.752 μs |     9.799 μs | 107,926.6 |  2.13 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |    48.103 μs |    24.4203 μs |   1.3386 μs |  0.7728 μs |    47.022 μs |    49.600 μs |  20,788.8 | 11.05 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |    74.811 μs |    57.7190 μs |   3.1638 μs |  1.8266 μs |    72.013 μs |    78.244 μs |  13,366.9 | 17.19 |      56 B |          NA |
|                               |           |            |              |               |             |            |              |              |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |    54.613 μs |   315.4563 μs |  17.2912 μs |  9.9831 μs |    42.319 μs |    74.385 μs |  18,310.6 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |    56.309 μs |    55.7556 μs |   3.0562 μs |  1.7645 μs |    53.136 μs |    59.233 μs |  17,759.3 |  1.10 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |    96.670 μs |    36.7576 μs |   2.0148 μs |  1.1632 μs |    94.442 μs |    98.362 μs |  10,344.4 |  1.88 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |    97.284 μs |    29.6327 μs |   1.6243 μs |  0.9378 μs |    96.287 μs |    99.158 μs |  10,279.2 |  1.88 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |   587.539 μs |   210.1372 μs |  11.5183 μs |  6.6501 μs |   575.992 μs |   599.028 μs |   1,702.0 | 11.41 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 1,188.590 μs | 2,872.8275 μs | 157.4694 μs | 90.9150 μs | 1,016.801 μs | 1,326.090 μs |     841.3 | 23.57 |      56 B |          NA |
