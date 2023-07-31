# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

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
|           ForWithIncrementBy1 |         1 |      10000 |   3.153 μs |   0.1253 μs |  0.0069 μs | 0.0040 μs |   3.146 μs |   3.160 μs | 317,182.6 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   3.251 μs |   1.1824 μs |  0.0648 μs | 0.0374 μs |   3.210 μs |   3.326 μs | 307,583.6 |  1.03 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |   8.681 μs |   1.6683 μs |  0.0914 μs | 0.0528 μs |   8.577 μs |   8.749 μs | 115,199.2 |  2.75 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |   8.805 μs |  19.6015 μs |  1.0744 μs | 0.6203 μs |   7.869 μs |   9.978 μs | 113,576.2 |  2.79 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  28.895 μs |   0.3513 μs |  0.0193 μs | 0.0111 μs |  28.874 μs |  28.913 μs |  34,608.6 |  9.16 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  33.145 μs |  18.0247 μs |  0.9880 μs | 0.5704 μs |  32.260 μs |  34.211 μs |  30,170.9 | 10.51 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  30.873 μs |   1.0989 μs |  0.0602 μs | 0.0348 μs |  30.805 μs |  30.918 μs |  32,390.4 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  31.981 μs |   2.4025 μs |  0.1317 μs | 0.0760 μs |  31.849 μs |  32.113 μs |  31,268.3 |  1.04 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 |  79.322 μs |  52.7116 μs |  2.8893 μs | 1.6681 μs |  76.188 μs |  81.880 μs |  12,606.8 |  2.57 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 |  86.776 μs | 120.0876 μs |  6.5824 μs | 3.8004 μs |  81.159 μs |  94.019 μs |  11,523.9 |  2.81 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 289.531 μs | 313.7281 μs | 17.1965 μs | 9.9284 μs | 278.665 μs | 309.357 μs |   3,453.9 |  9.38 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 342.066 μs | 295.2941 μs | 16.1861 μs | 9.3450 μs | 324.454 μs | 356.291 μs |   2,923.4 | 11.08 |      56 B |          NA |
