# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |      Error |    StdDev | Ratio | RatioSD | Allocated |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|------:|--------:|----------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.160 μs |  5.8619 μs | 0.3213 μs |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |      10000 |   3.433 μs |  8.0534 μs | 0.4414 μs |  1.10 |    0.25 |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |  14.932 μs |  1.0074 μs | 0.0552 μs |  4.76 |    0.53 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |  14.943 μs |  0.9904 μs | 0.0543 μs |  4.76 |    0.52 |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  39.284 μs |  6.7904 μs | 0.3722 μs | 12.53 |    1.47 |      41 B |
|        ForeachWithYieldReturn |         1 |      10000 |  44.751 μs |  7.1456 μs | 0.3917 μs | 14.27 |    1.54 |      56 B |
|                               |           |            |            |            |           |       |         |           |
|           ForWithIncrementBy1 |         1 |     100000 |  27.185 μs |  6.5078 μs | 0.3567 μs |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |     100000 |  28.296 μs | 16.7587 μs | 0.9186 μs |  1.04 |    0.02 |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 | 150.327 μs |  2.2171 μs | 0.1215 μs |  5.53 |    0.07 |       3 B |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 | 153.949 μs | 11.2352 μs | 0.6158 μs |  5.66 |    0.09 |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 383.245 μs | 40.1188 μs | 2.1990 μs | 14.10 |    0.25 |      40 B |
|        ForeachWithYieldReturn |         1 |     100000 | 460.936 μs | 43.1888 μs | 2.3673 μs | 16.96 |    0.16 |      56 B |
