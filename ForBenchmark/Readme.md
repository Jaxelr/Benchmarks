# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.301
  [Host]   : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  ShortRun : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |    StdDev |    StdErr |        Min |         Q1 |     Median |         Q3 |        Max |      Op/s | Ratio | RatioSD | Allocated |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|--------:|----------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.300 μs |   1.9406 μs | 0.1064 μs | 0.0614 μs |   3.195 μs |   3.246 μs |   3.297 μs |   3.353 μs |   3.408 μs | 303,000.5 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |      10000 |   3.308 μs |   0.7863 μs | 0.0431 μs | 0.0249 μs |   3.259 μs |   3.292 μs |   3.326 μs |   3.333 μs |   3.339 μs | 302,301.9 |  1.00 |    0.02 |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |   7.262 μs |  12.9376 μs | 0.7092 μs | 0.4094 μs |   6.491 μs |   6.950 μs |   7.409 μs |   7.647 μs |   7.886 μs | 137,707.9 |  2.20 |    0.15 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   8.010 μs |   8.7427 μs | 0.4792 μs | 0.2767 μs |   7.460 μs |   7.846 μs |   8.232 μs |   8.285 μs |   8.338 μs | 124,844.3 |  2.43 |    0.16 |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  30.803 μs |  11.6870 μs | 0.6406 μs | 0.3699 μs |  30.260 μs |  30.450 μs |  30.641 μs |  31.075 μs |  31.509 μs |  32,464.1 |  9.34 |    0.12 |      40 B |
|        ForeachWithYieldReturn |         1 |      10000 |  37.753 μs |  16.1337 μs | 0.8843 μs | 0.5106 μs |  37.179 μs |  37.244 μs |  37.309 μs |  38.040 μs |  38.772 μs |  26,487.7 | 11.45 |    0.61 |      56 B |
|                               |           |            |            |             |           |           |            |            |            |            |            |           |       |         |           |
|           ForWithIncrementBy1 |         1 |     100000 |  31.064 μs |   2.9602 μs | 0.1623 μs | 0.0937 μs |  30.957 μs |  30.971 μs |  30.984 μs |  31.117 μs |  31.251 μs |  32,191.5 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |     100000 |  32.417 μs |   3.3435 μs | 0.1833 μs | 0.1058 μs |  32.222 μs |  32.333 μs |  32.444 μs |  32.515 μs |  32.586 μs |  30,847.6 |  1.04 |    0.01 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  68.108 μs |  21.0577 μs | 1.1542 μs | 0.6664 μs |  67.297 μs |  67.447 μs |  67.596 μs |  68.513 μs |  69.429 μs |  14,682.6 |  2.19 |    0.04 |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 |  68.904 μs |  30.5868 μs | 1.6766 μs | 0.9680 μs |  66.968 μs |  68.413 μs |  69.857 μs |  69.872 μs |  69.887 μs |  14,512.9 |  2.22 |    0.05 |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 280.593 μs | 101.4231 μs | 5.5593 μs | 3.2097 μs | 275.083 μs | 277.789 μs | 280.495 μs | 283.348 μs | 286.201 μs |   3,563.9 |  9.03 |    0.19 |      40 B |
|        ForeachWithYieldReturn |         1 |     100000 | 356.093 μs |  56.5279 μs | 3.0985 μs | 1.7889 μs | 352.649 μs | 354.814 μs | 356.979 μs | 357.816 μs | 358.653 μs |   2,808.3 | 11.46 |    0.16 |      56 B |
