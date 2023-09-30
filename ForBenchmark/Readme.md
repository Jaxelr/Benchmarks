# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |    StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.218 μs |   0.8454 μs |  0.0463 μs | 0.0268 μs |   3.170 μs |   3.263 μs | 310,748.5 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.321 μs |   1.9043 μs |  0.1044 μs | 0.0603 μs |   3.260 μs |   3.441 μs | 301,130.6 |  1.03 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   9.033 μs |   1.8523 μs |  0.1015 μs | 0.0586 μs |   8.927 μs |   9.129 μs | 110,706.4 |  2.81 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |  10.797 μs |   9.6242 μs |  0.5275 μs | 0.3046 μs |  10.197 μs |  11.188 μs |  92,615.8 |  3.36 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  30.093 μs |  18.7886 μs |  1.0299 μs | 0.5946 μs |  28.914 μs |  30.817 μs |  33,229.9 |  9.35 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  33.693 μs |  32.4792 μs |  1.7803 μs | 1.0279 μs |  32.114 μs |  35.622 μs |  29,679.6 | 10.48 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
|        ForWithCustomIncrement |         1 |     100000 |  37.957 μs |  39.6851 μs |  2.1753 μs | 1.2559 μs |  35.600 μs |  39.888 μs |  26,345.6 |  0.98 |         - |          NA |
|           ForWithIncrementBy1 |         1 |     100000 |  39.265 μs |  80.7420 μs |  4.4257 μs | 2.5552 μs |  36.331 μs |  44.355 μs |  25,468.2 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  95.674 μs | 141.1651 μs |  7.7377 μs | 4.4674 μs |  87.843 μs | 103.315 μs |  10,452.2 |  2.47 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 | 110.698 μs | 244.5353 μs | 13.4038 μs | 7.7387 μs |  98.376 μs | 124.970 μs |   9,033.6 |  2.84 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 361.250 μs | 187.6747 μs | 10.2871 μs | 5.9392 μs | 349.549 μs | 368.875 μs |   2,768.2 |  9.27 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 422.090 μs | 276.0345 μs | 15.1304 μs | 8.7355 μs | 410.581 μs | 439.228 μs |   2,369.2 | 10.84 |      56 B |          NA |
