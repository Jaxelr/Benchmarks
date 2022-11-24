# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |     StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.516 μs |   2.4419 μs |  0.1338 μs |  0.0773 μs |   3.362 μs |   3.603 μs | 284,408.8 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   4.439 μs |   0.9528 μs |  0.0522 μs |  0.0302 μs |   4.379 μs |   4.472 μs | 225,257.2 |  1.26 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   9.201 μs |  18.7783 μs |  1.0293 μs |  0.5943 μs |   8.586 μs |  10.389 μs | 108,688.4 |  2.62 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |  10.154 μs |  13.1195 μs |  0.7191 μs |  0.4152 μs |   9.627 μs |  10.973 μs |  98,481.8 |  2.90 |         - |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  45.821 μs |  40.3637 μs |  2.2125 μs |  1.2774 μs |  44.436 μs |  48.373 μs |  21,823.9 | 13.04 |      56 B |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  49.612 μs |  47.8617 μs |  2.6235 μs |  1.5147 μs |  47.831 μs |  52.625 μs |  20,156.3 | 14.12 |      40 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  34.089 μs |  23.6043 μs |  1.2938 μs |  0.7470 μs |  32.680 μs |  35.224 μs |  29,335.2 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  39.199 μs |  14.6718 μs |  0.8042 μs |  0.4643 μs |  38.672 μs |  40.125 μs |  25,510.9 |  1.15 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  78.794 μs |  78.3960 μs |  4.2972 μs |  2.4810 μs |  74.267 μs |  82.817 μs |  12,691.4 |  2.31 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  80.108 μs |  94.7014 μs |  5.1909 μs |  2.9970 μs |  74.852 μs |  85.231 μs |  12,483.2 |  2.35 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 383.687 μs | 682.6541 μs | 37.4186 μs | 21.6036 μs | 353.081 μs | 425.402 μs |   2,606.3 | 11.25 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 405.777 μs | 246.0455 μs | 13.4866 μs |  7.7865 μs | 391.615 μs | 418.467 μs |   2,464.4 | 11.91 |      56 B |          NA |
