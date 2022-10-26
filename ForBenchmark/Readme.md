# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |    StdDev |    StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.177 μs |   2.1686 μs | 0.1189 μs | 0.0686 μs |   3.102 μs |   3.314 μs | 314,794.6 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.231 μs |   0.5954 μs | 0.0326 μs | 0.0188 μs |   3.206 μs |   3.268 μs | 309,499.2 |  1.02 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   6.352 μs |   1.1627 μs | 0.0637 μs | 0.0368 μs |   6.279 μs |   6.398 μs | 157,423.5 |  2.00 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   6.653 μs |   4.3370 μs | 0.2377 μs | 0.1373 μs |   6.516 μs |   6.927 μs | 150,308.7 |  2.09 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  28.538 μs |   5.5848 μs | 0.3061 μs | 0.1767 μs |  28.322 μs |  28.889 μs |  35,040.5 |  8.99 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  34.911 μs |   4.5072 μs | 0.2471 μs | 0.1426 μs |  34.626 μs |  35.067 μs |  28,644.2 | 11.00 |      56 B |          NA |
|                               |           |            |            |             |           |           |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  31.241 μs |   0.9978 μs | 0.0547 μs | 0.0316 μs |  31.180 μs |  31.283 μs |  32,008.8 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  32.842 μs |  13.0739 μs | 0.7166 μs | 0.4137 μs |  32.206 μs |  33.618 μs |  30,448.5 |  1.05 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  63.582 μs |  10.1140 μs | 0.5544 μs | 0.3201 μs |  63.206 μs |  64.219 μs |  15,727.7 |  2.04 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  67.629 μs |  30.2389 μs | 1.6575 μs | 0.9570 μs |  66.594 μs |  69.541 μs |  14,786.6 |  2.16 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 285.418 μs |  72.2289 μs | 3.9591 μs | 2.2858 μs | 282.311 μs | 289.876 μs |   3,503.6 |  9.14 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 355.944 μs | 160.3029 μs | 8.7867 μs | 5.0730 μs | 349.309 μs | 365.909 μs |   2,809.4 | 11.39 |      56 B |          NA |
