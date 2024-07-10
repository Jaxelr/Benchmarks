# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |  3.158 μs |  0.1513 μs | 0.0083 μs | 0.0048 μs |  3.149 μs |  3.166 μs | 316,651.7 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |  3.242 μs |  0.2527 μs | 0.0139 μs | 0.0080 μs |  3.231 μs |  3.258 μs | 308,451.2 |  1.03 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  6.342 μs |  1.3932 μs | 0.0764 μs | 0.0441 μs |  6.289 μs |  6.429 μs | 157,687.5 |  2.01 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  7.159 μs |  6.6907 μs | 0.3667 μs | 0.2117 μs |  6.872 μs |  7.573 μs | 139,675.3 |  2.27 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  8.700 μs | 49.1616 μs | 2.6947 μs | 1.5558 μs |  6.798 μs | 11.784 μs | 114,938.3 |  2.76 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  9.781 μs |  0.3531 μs | 0.0194 μs | 0.0112 μs |  9.770 μs |  9.803 μs | 102,238.2 |  3.10 |      56 B |          NA |
|                               |           |            |           |            |           |           |           |           |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     | 31.444 μs |  3.8687 μs | 0.2121 μs | 0.1224 μs | 31.208 μs | 31.617 μs |  31,802.2 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     | 32.523 μs |  1.2865 μs | 0.0705 μs | 0.0407 μs | 32.475 μs | 32.604 μs |  30,747.4 |  1.03 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 63.361 μs |  5.1352 μs | 0.2815 μs | 0.1625 μs | 63.095 μs | 63.656 μs |  15,782.6 |  2.02 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 65.041 μs |  4.7870 μs | 0.2624 μs | 0.1515 μs | 64.879 μs | 65.344 μs |  15,374.8 |  2.07 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 68.974 μs | 59.1277 μs | 3.2410 μs | 1.8712 μs | 65.264 μs | 71.253 μs |  14,498.2 |  2.19 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 95.591 μs | 10.8706 μs | 0.5959 μs | 0.3440 μs | 94.926 μs | 96.076 μs |  10,461.3 |  3.04 |      56 B |          NA |
