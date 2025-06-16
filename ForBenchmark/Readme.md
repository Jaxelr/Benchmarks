# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.486 μs |   0.1657 μs |  0.0091 μs |  0.0052 μs |   2.479 μs |   2.496 μs | 402,302.5 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.209 μs |   0.2578 μs |  0.0141 μs |  0.0082 μs |   3.198 μs |   3.225 μs | 311,653.4 |  1.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.259 μs |   0.6691 μs |  0.0367 μs |  0.0212 μs |   3.219 μs |   3.291 μs | 306,861.0 |  1.31 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.480 μs |   1.2799 μs |  0.0702 μs |  0.0405 μs |   3.424 μs |   3.559 μs | 287,357.1 |  1.40 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.539 μs |   1.9665 μs |  0.1078 μs |  0.0622 μs |   6.468 μs |   6.663 μs | 152,918.5 |  2.63 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  17.797 μs |   1.0282 μs |  0.0564 μs |  0.0325 μs |  17.734 μs |  17.841 μs |  56,188.6 |  7.16 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  25.208 μs |   3.8725 μs |  0.2123 μs |  0.1226 μs |  25.002 μs |  25.426 μs |  39,669.8 |  1.00 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  32.889 μs |  11.0195 μs |  0.6040 μs |  0.3487 μs |  32.501 μs |  33.585 μs |  30,405.7 |  1.30 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  33.340 μs |   9.7486 μs |  0.5344 μs |  0.3085 μs |  32.739 μs |  33.761 μs |  29,994.2 |  1.32 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  35.803 μs |  15.9324 μs |  0.8733 μs |  0.5042 μs |  34.932 μs |  36.679 μs |  27,930.5 |  1.42 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 175.797 μs | 370.8496 μs | 20.3275 μs | 11.7361 μs | 152.325 μs | 187.615 μs |   5,688.4 |  6.97 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 195.992 μs |  48.2321 μs |  2.6438 μs |  1.5264 μs | 193.648 μs | 198.858 μs |   5,102.2 |  7.78 |      56 B |          NA |
