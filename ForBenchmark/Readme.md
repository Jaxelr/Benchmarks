# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.553 μs |  0.6985 μs | 0.0383 μs | 0.0221 μs |   2.526 μs |   2.597 μs | 391,653.8 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.215 μs |  0.2344 μs | 0.0128 μs | 0.0074 μs |   3.202 μs |   3.228 μs | 311,052.4 |  1.26 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.218 μs |  0.4066 μs | 0.0223 μs | 0.0129 μs |   3.198 μs |   3.242 μs | 310,755.3 |  1.26 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.378 μs |  0.7087 μs | 0.0388 μs | 0.0224 μs |   3.333 μs |   3.404 μs | 296,020.1 |  1.32 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.481 μs |  1.8346 μs | 0.1006 μs | 0.0581 μs |   6.365 μs |   6.544 μs | 154,289.1 |  2.54 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  17.927 μs |  0.6824 μs | 0.0374 μs | 0.0216 μs |  17.884 μs |  17.950 μs |  55,780.6 |  7.02 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  24.764 μs |  1.1029 μs | 0.0605 μs | 0.0349 μs |  24.695 μs |  24.811 μs |  40,382.0 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  32.035 μs |  1.3590 μs | 0.0745 μs | 0.0430 μs |  31.986 μs |  32.121 μs |  31,215.4 |  1.29 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.154 μs |  1.8152 μs | 0.0995 μs | 0.0574 μs |  32.097 μs |  32.269 μs |  31,100.2 |  1.30 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  33.059 μs | 17.1282 μs | 0.9389 μs | 0.5420 μs |  32.377 μs |  34.130 μs |  30,248.7 |  1.34 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  63.623 μs |  4.2310 μs | 0.2319 μs | 0.1339 μs |  63.365 μs |  63.815 μs |  15,717.6 |  2.57 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 181.311 μs |  9.6835 μs | 0.5308 μs | 0.3064 μs | 180.753 μs | 181.810 μs |   5,515.4 |  7.32 |      56 B |          NA |
