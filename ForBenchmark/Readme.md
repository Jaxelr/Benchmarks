# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |     StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   3.312 μs |   0.3945 μs |  0.0216 μs |  0.0125 μs |   3.298 μs |   3.337 μs | 301,895.0 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.419 μs |   1.0178 μs |  0.0558 μs |  0.0322 μs |   3.383 μs |   3.483 μs | 292,507.8 |  1.03 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   8.688 μs |   5.7977 μs |  0.3178 μs |  0.1835 μs |   8.492 μs |   9.055 μs | 115,102.8 |  2.62 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   9.598 μs |  13.7146 μs |  0.7517 μs |  0.4340 μs |   9.056 μs |  10.456 μs | 104,189.2 |  2.90 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  33.503 μs |  35.2052 μs |  1.9297 μs |  1.1141 μs |  31.913 μs |  35.650 μs |  29,848.0 | 10.11 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  49.314 μs |  97.0899 μs |  5.3218 μs |  3.0726 μs |  44.346 μs |  54.930 μs |  20,278.2 | 14.89 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  32.318 μs |  10.4740 μs |  0.5741 μs |  0.3315 μs |  31.657 μs |  32.689 μs |  30,942.1 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  33.529 μs |   6.6786 μs |  0.3661 μs |  0.2114 μs |  33.163 μs |  33.895 μs |  29,824.9 |  1.04 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  77.373 μs |  69.8868 μs |  3.8307 μs |  2.2117 μs |  74.348 μs |  81.680 μs |  12,924.4 |  2.39 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  78.080 μs |  32.7269 μs |  1.7939 μs |  1.0357 μs |  76.194 μs |  79.765 μs |  12,807.4 |  2.42 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 311.934 μs |  96.7022 μs |  5.3006 μs |  3.0603 μs | 307.016 μs | 317.548 μs |   3,205.8 |  9.65 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 471.304 μs | 458.0290 μs | 25.1061 μs | 14.4950 μs | 442.388 μs | 487.556 μs |   2,121.8 | 14.59 |      56 B |          NA |
