# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]   : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  ShortRun : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |    StdDev |    StdErr |        Min |         Q1 |     Median |         Q3 |        Max |      Op/s | Ratio | RatioSD | Allocated |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|--------:|----------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.166 μs |   0.5798 μs | 0.0318 μs | 0.0183 μs |   3.143 μs |   3.147 μs |   3.151 μs |   3.177 μs |   3.202 μs | 315,905.2 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |      10000 |   3.259 μs |   0.3377 μs | 0.0185 μs | 0.0107 μs |   3.240 μs |   3.250 μs |   3.260 μs |   3.268 μs |   3.277 μs | 306,853.8 |  1.03 |    0.02 |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |   7.514 μs |   3.4516 μs | 0.1892 μs | 0.1092 μs |   7.363 μs |   7.408 μs |   7.454 μs |   7.590 μs |   7.726 μs | 133,080.5 |  2.37 |    0.07 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   7.573 μs |   2.2042 μs | 0.1208 μs | 0.0698 μs |   7.437 μs |   7.527 μs |   7.617 μs |   7.642 μs |   7.666 μs | 132,040.3 |  2.39 |    0.04 |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  30.319 μs |  29.3327 μs | 1.6078 μs | 0.9283 μs |  29.373 μs |  29.391 μs |  29.409 μs |  30.792 μs |  32.176 μs |  32,982.2 |  9.58 |    0.55 |      40 B |
|        ForeachWithYieldReturn |         1 |      10000 |  35.198 μs |   4.7662 μs | 0.2613 μs | 0.1508 μs |  34.949 μs |  35.062 μs |  35.175 μs |  35.322 μs |  35.470 μs |  28,410.6 | 11.12 |    0.15 |      56 B |
|                               |           |            |            |             |           |           |            |            |            |            |            |           |       |         |           |
|           ForWithIncrementBy1 |         1 |     100000 |  31.393 μs |   4.7356 μs | 0.2596 μs | 0.1499 μs |  31.151 μs |  31.255 μs |  31.360 μs |  31.513 μs |  31.667 μs |  31,854.7 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |     100000 |  32.403 μs |   4.5962 μs | 0.2519 μs | 0.1455 μs |  32.223 μs |  32.260 μs |  32.296 μs |  32.494 μs |  32.691 μs |  30,860.9 |  1.03 |    0.02 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  71.784 μs |  42.6650 μs | 2.3386 μs | 1.3502 μs |  70.360 μs |  70.434 μs |  70.509 μs |  72.496 μs |  74.483 μs |  13,930.7 |  2.29 |    0.06 |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 |  75.085 μs |  42.7343 μs | 2.3424 μs | 1.3524 μs |  73.719 μs |  73.733 μs |  73.747 μs |  75.769 μs |  77.790 μs |  13,318.2 |  2.39 |    0.09 |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 289.874 μs | 152.0659 μs | 8.3352 μs | 4.8124 μs | 280.250 μs | 287.442 μs | 294.634 μs | 294.686 μs | 294.738 μs |   3,449.8 |  9.24 |    0.34 |      40 B |
|        ForeachWithYieldReturn |         1 |     100000 | 360.617 μs |  31.6449 μs | 1.7346 μs | 1.0014 μs | 359.214 μs | 359.648 μs | 360.081 μs | 361.319 μs | 362.557 μs |   2,773.0 | 11.49 |    0.10 |      56 B |
