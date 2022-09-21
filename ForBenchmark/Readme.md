# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |    StdErr |        Min |         Q1 |     Median |         Q3 |        Max |      Op/s | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|--------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.138 μs |   0.7275 μs |  0.0399 μs | 0.0230 μs |   3.103 μs |   3.117 μs |   3.131 μs |   3.156 μs |   3.181 μs | 318,631.0 |  1.00 |    0.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.253 μs |   0.3195 μs |  0.0175 μs | 0.0101 μs |   3.233 μs |   3.247 μs |   3.261 μs |   3.263 μs |   3.266 μs | 307,397.6 |  1.04 |    0.02 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   6.464 μs |   1.6331 μs |  0.0895 μs | 0.0517 μs |   6.393 μs |   6.413 μs |   6.433 μs |   6.499 μs |   6.564 μs | 154,712.6 |  2.06 |    0.05 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   6.541 μs |   0.7042 μs |  0.0386 μs | 0.0223 μs |   6.499 μs |   6.525 μs |   6.550 μs |   6.562 μs |   6.575 μs | 152,870.8 |  2.08 |    0.02 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  28.567 μs |   7.3876 μs |  0.4049 μs | 0.2338 μs |  28.128 μs |  28.388 μs |  28.647 μs |  28.786 μs |  28.926 μs |  35,005.6 |  9.10 |    0.23 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  35.576 μs |  12.8374 μs |  0.7037 μs | 0.4063 μs |  34.907 μs |  35.209 μs |  35.510 μs |  35.910 μs |  36.310 μs |  28,108.9 | 11.34 |    0.33 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |            |            |            |           |       |         |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  31.349 μs |   2.0031 μs |  0.1098 μs | 0.0634 μs |  31.222 μs |  31.317 μs |  31.412 μs |  31.412 μs |  31.413 μs |  31,899.2 |  1.00 |    0.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  32.631 μs |  16.7170 μs |  0.9163 μs | 0.5290 μs |  32.036 μs |  32.103 μs |  32.170 μs |  32.928 μs |  33.686 μs |  30,645.9 |  1.04 |    0.03 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  67.904 μs |  40.4488 μs |  2.2171 μs | 1.2801 μs |  65.672 μs |  66.803 μs |  67.934 μs |  69.020 μs |  70.106 μs |  14,726.6 |  2.17 |    0.07 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  67.967 μs |  66.6167 μs |  3.6515 μs | 2.1082 μs |  63.908 μs |  66.458 μs |  69.008 μs |  69.996 μs |  70.984 μs |  14,713.1 |  2.17 |    0.12 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 282.382 μs | 101.3287 μs |  5.5542 μs | 3.2067 μs | 276.320 μs | 279.959 μs | 283.598 μs | 285.413 μs | 287.227 μs |   3,541.3 |  9.01 |    0.20 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 358.233 μs | 233.5156 μs | 12.7998 μs | 7.3900 μs | 348.568 μs | 350.975 μs | 353.381 μs | 363.065 μs | 372.749 μs |   2,791.5 | 11.43 |    0.45 |      56 B |          NA |
