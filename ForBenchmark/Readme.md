# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |    StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|        ForWithCustomIncrement |         1 |      10000 |   3.320 μs |   0.7725 μs |  0.0423 μs | 0.0244 μs |   3.291 μs |   3.368 μs | 301,235.9 |  0.97 |         - |          NA |
|           ForWithIncrementBy1 |         1 |      10000 |   3.421 μs |   4.2429 μs |  0.2326 μs | 0.1343 μs |   3.244 μs |   3.684 μs | 292,344.8 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   9.935 μs |  22.2066 μs |  1.2172 μs | 0.7028 μs |   9.118 μs |  11.334 μs | 100,658.1 |  2.92 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |  10.735 μs |  18.2412 μs |  0.9999 μs | 0.5773 μs |   9.581 μs |  11.354 μs |  93,155.8 |  3.16 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  29.714 μs |   5.2963 μs |  0.2903 μs | 0.1676 μs |  29.541 μs |  30.049 μs |  33,654.5 |  8.72 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  36.152 μs |  29.5890 μs |  1.6219 μs | 0.9364 μs |  35.121 μs |  38.022 μs |  27,660.8 | 10.58 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
|        ForWithCustomIncrement |         1 |     100000 |  32.321 μs |   3.7750 μs |  0.2069 μs | 0.1195 μs |  32.086 μs |  32.477 μs |  30,939.6 |  0.97 |         - |          NA |
|           ForWithIncrementBy1 |         1 |     100000 |  33.542 μs |  43.7203 μs |  2.3965 μs | 1.3836 μs |  31.962 μs |  36.299 μs |  29,813.7 |  1.00 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  79.669 μs |  58.1162 μs |  3.1855 μs | 1.8392 μs |  76.523 μs |  82.893 μs |  12,551.9 |  2.38 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  81.751 μs | 110.6065 μs |  6.0627 μs | 3.5003 μs |  74.876 μs |  86.332 μs |  12,232.2 |  2.45 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 350.593 μs | 315.6830 μs | 17.3037 μs | 9.9903 μs | 337.466 μs | 370.202 μs |   2,852.3 | 10.50 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 365.902 μs |  45.4760 μs |  2.4927 μs | 1.4392 μs | 363.024 μs | 367.347 μs |   2,733.0 | 10.94 |      56 B |          NA |
