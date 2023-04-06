# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |      Error |    StdDev |    StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.146 μs |  1.2113 μs | 0.0664 μs | 0.0383 μs |   3.097 μs |   3.221 μs | 317,898.1 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.248 μs |  0.5614 μs | 0.0308 μs | 0.0178 μs |   3.213 μs |   3.271 μs | 307,841.1 |  1.03 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   8.179 μs |  4.5022 μs | 0.2468 μs | 0.1425 μs |   7.922 μs |   8.414 μs | 122,265.8 |  2.60 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   8.667 μs |  5.6548 μs | 0.3100 μs | 0.1790 μs |   8.402 μs |   9.008 μs | 115,381.9 |  2.76 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  30.014 μs |  7.0096 μs | 0.3842 μs | 0.2218 μs |  29.650 μs |  30.415 μs |  33,318.1 |  9.55 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  35.074 μs |  7.9953 μs | 0.4383 μs | 0.2530 μs |  34.703 μs |  35.557 μs |  28,511.1 | 11.15 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  30.979 μs |  1.4591 μs | 0.0800 μs | 0.0462 μs |  30.888 μs |  31.038 μs |  32,279.8 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  32.541 μs |  5.0553 μs | 0.2771 μs | 0.1600 μs |  32.352 μs |  32.859 μs |  30,730.1 |  1.05 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  79.542 μs | 64.5935 μs | 3.5406 μs | 2.0442 μs |  76.326 μs |  83.336 μs |  12,571.9 |  2.57 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  80.473 μs | 40.4053 μs | 2.2148 μs | 1.2787 μs |  78.244 μs |  82.673 μs |  12,426.5 |  2.60 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 306.631 μs | 85.9520 μs | 4.7113 μs | 2.7201 μs | 302.103 μs | 311.507 μs |   3,261.2 |  9.90 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 349.526 μs | 19.9478 μs | 1.0934 μs | 0.6313 μs | 348.526 μs | 350.694 μs |   2,861.0 | 11.28 |      56 B |          NA |
