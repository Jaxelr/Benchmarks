# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |        Error |     StdDev |     StdErr |        Min |         Q1 |     Median |         Q3 |        Max |      Op/s | Ratio | RatioSD | Allocated |
|------------------------------ |---------- |----------- |-----------:|-------------:|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|--------:|----------:|
|        ForWithCustomIncrement |         1 |      10000 |   3.088 μs |     1.912 μs |  0.1048 μs |  0.0605 μs |   2.967 μs |   3.057 μs |   3.147 μs |   3.148 μs |   3.149 μs | 323,881.6 |  0.94 |    0.16 |         - |
|           ForWithIncrementBy1 |         1 |      10000 |   3.343 μs |     9.911 μs |  0.5432 μs |  0.3136 μs |   2.801 μs |   3.072 μs |   3.342 μs |   3.615 μs |   3.887 μs | 299,089.9 |  1.00 |    0.00 |         - |
|    ForeachWithRangeEnumerator |         1 |      10000 |  14.243 μs |    11.949 μs |  0.6549 μs |  0.3781 μs |  13.699 μs |  13.879 μs |  14.060 μs |  14.515 μs |  14.970 μs |  70,209.7 |  4.36 |    0.92 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |  15.952 μs |    12.911 μs |  0.7077 μs |  0.4086 μs |  15.292 μs |  15.578 μs |  15.864 μs |  16.281 μs |  16.699 μs |  62,689.8 |  4.86 |    0.87 |         - |
|    ForeachWithEnumerableRange |         1 |      10000 |  37.723 μs |    26.738 μs |  1.4656 μs |  0.8462 μs |  36.036 μs |  37.246 μs |  38.456 μs |  38.567 μs |  38.678 μs |  26,508.7 | 11.52 |    2.23 |      40 B |
|        ForeachWithYieldReturn |         1 |      10000 |  40.777 μs |     9.571 μs |  0.5246 μs |  0.3029 μs |  40.436 μs |  40.475 μs |  40.515 μs |  40.948 μs |  41.381 μs |  24,523.4 | 12.42 |    2.03 |      56 B |
|                               |           |            |            |              |            |            |            |            |            |            |            |           |       |         |           |
|           ForWithIncrementBy1 |         1 |     100000 |  24.773 μs |     2.947 μs |  0.1615 μs |  0.0933 μs |  24.600 μs |  24.699 μs |  24.798 μs |  24.859 μs |  24.920 μs |  40,366.9 |  1.00 |    0.00 |         - |
|        ForWithCustomIncrement |         1 |     100000 |  27.764 μs |    43.779 μs |  2.3997 μs |  1.3854 μs |  25.360 μs |  26.567 μs |  27.773 μs |  28.966 μs |  30.159 μs |  36,017.6 |  1.12 |    0.09 |         - |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 | 139.351 μs |    31.543 μs |  1.7290 μs |  0.9982 μs | 137.376 μs | 138.731 μs | 140.087 μs | 140.339 μs | 140.591 μs |   7,176.1 |  5.63 |    0.04 |         - |
|    ForeachWithRangeEnumerator |         1 |     100000 | 142.227 μs |    16.533 μs |  0.9063 μs |  0.5232 μs | 141.504 μs | 141.719 μs | 141.933 μs | 142.588 μs | 143.244 μs |   7,031.0 |  5.74 |    0.05 |         - |
|    ForeachWithEnumerableRange |         1 |     100000 | 388.648 μs |   288.896 μs | 15.8354 μs |  9.1426 μs | 378.542 μs | 379.523 μs | 380.505 μs | 393.702 μs | 406.898 μs |   2,573.0 | 15.69 |    0.56 |      40 B |
|        ForeachWithYieldReturn |         1 |     100000 | 586.150 μs | 1,676.506 μs | 91.8950 μs | 53.0556 μs | 480.365 μs | 556.100 μs | 631.836 μs | 639.042 μs | 646.248 μs |   1,706.0 | 23.67 |    3.75 |      56 B |
