# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |      Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|           ForWithIncrementBy1 |         1 |      10000 |   2.781 μs |  0.3887 μs | 0.0213 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|        ForWithCustomIncrement |         1 |      10000 |   2.920 μs |  2.9070 μs | 0.1593 μs |  1.05 |    0.07 |     - |     - |     - |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |  15.088 μs |  0.8701 μs | 0.0477 μs |  5.43 |    0.04 |     - |     - |     - |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |  15.115 μs |  1.2495 μs | 0.0685 μs |  5.43 |    0.05 |     - |     - |     - |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  41.683 μs |  2.1943 μs | 0.1203 μs | 14.99 |    0.11 |     - |     - |     - |      41 B |
|        ForeachWithYieldReturn |         1 |      10000 |  44.465 μs |  3.2998 μs | 0.1809 μs | 15.99 |    0.16 |     - |     - |     - |      56 B |
|                               |           |            |            |            |           |       |         |       |       |       |           |
|        ForWithCustomIncrement |         1 |     100000 |  27.466 μs |  1.9289 μs | 0.1057 μs |  0.99 |    0.02 |     - |     - |     - |         - |
|           ForWithIncrementBy1 |         1 |     100000 |  27.817 μs | 12.9800 μs | 0.7115 μs |  1.00 |    0.00 |     - |     - |     - |         - |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 | 151.130 μs |  4.7452 μs | 0.2601 μs |  5.44 |    0.13 |     - |     - |     - |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 | 152.227 μs | 30.9068 μs | 1.6941 μs |  5.48 |    0.18 |     - |     - |     - |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 414.768 μs | 93.6419 μs | 5.1328 μs | 14.92 |    0.54 |     - |     - |     - |      47 B |
|        ForeachWithYieldReturn |         1 |     100000 | 475.149 μs | 53.5424 μs | 2.9348 μs | 17.09 |    0.49 |     - |     - |     - |      56 B |
