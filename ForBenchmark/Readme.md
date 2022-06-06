# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |    StdDev |    StdErr |        Min |         Q1 |     Median |         Q3 |        Max |      Op/s | Ratio | RatioSD | Allocated |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|--------:|----------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.209 μs |   2.0618 μs | 0.1130 μs | 0.0652 μs |   3.112 μs |   3.147 μs |   3.182 μs |   3.258 μs |   3.333 μs | 311,609.2 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |      10000 |   3.235 μs |   0.6366 μs | 0.0349 μs | 0.0201 μs |   3.209 μs |   3.215 μs |   3.222 μs |   3.248 μs |   3.275 μs | 309,092.5 |  1.01 |    0.04 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   6.497 μs |   1.2850 μs | 0.0704 μs | 0.0407 μs |   6.445 μs |   6.457 μs |   6.469 μs |   6.523 μs |   6.577 μs | 153,909.9 |  2.03 |    0.09 |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |   6.557 μs |   0.3053 μs | 0.0167 μs | 0.0097 μs |   6.547 μs |   6.547 μs |   6.547 μs |   6.562 μs |   6.576 μs | 152,515.7 |  2.04 |    0.07 |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  30.212 μs |   9.2329 μs | 0.5061 μs | 0.2922 μs |  29.797 μs |  29.929 μs |  30.062 μs |  30.419 μs |  30.776 μs |  33,100.0 |  9.42 |    0.44 |      40 B |
|        ForeachWithYieldReturn |         1 |      10000 |  35.510 μs |   2.0859 μs | 0.1143 μs | 0.0660 μs |  35.443 μs |  35.444 μs |  35.445 μs |  35.544 μs |  35.642 μs |  28,161.0 | 11.07 |    0.35 |      56 B |
|                               |           |            |            |             |           |           |            |            |            |            |            |           |       |         |           |
|           ForWithIncrementBy1 |         1 |     100000 |  31.188 μs |   6.4182 μs | 0.3518 μs | 0.2031 μs |  30.927 μs |  30.988 μs |  31.048 μs |  31.318 μs |  31.588 μs |  32,063.8 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |     100000 |  32.367 μs |   4.2504 μs | 0.2330 μs | 0.1345 μs |  32.144 μs |  32.246 μs |  32.348 μs |  32.479 μs |  32.609 μs |  30,895.7 |  1.04 |    0.00 |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 |  67.971 μs |  48.5980 μs | 2.6638 μs | 1.5380 μs |  65.578 μs |  66.537 μs |  67.495 μs |  69.168 μs |  70.841 μs |  14,712.1 |  2.18 |    0.06 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  71.434 μs |  16.7282 μs | 0.9169 μs | 0.5294 μs |  70.630 μs |  70.934 μs |  71.239 μs |  71.836 μs |  72.432 μs |  13,999.0 |  2.29 |    0.01 |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 302.111 μs | 109.5174 μs | 6.0030 μs | 3.4658 μs | 295.266 μs | 299.926 μs | 304.587 μs | 305.533 μs | 306.480 μs |   3,310.0 |  9.69 |    0.17 |      40 B |
|        ForeachWithYieldReturn |         1 |     100000 | 358.894 μs | 131.4410 μs | 7.2047 μs | 4.1596 μs | 351.629 μs | 355.323 μs | 359.018 μs | 362.527 μs | 366.036 μs |   2,786.3 | 11.51 |    0.28 |      56 B |
