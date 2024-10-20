# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   3.218 μs |   0.6987 μs |  0.0383 μs |  0.0221 μs |   3.175 μs |   3.249 μs | 310,714.7 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.318 μs |   0.4338 μs |  0.0238 μs |  0.0137 μs |   3.292 μs |   3.339 μs | 301,414.7 |  1.03 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.488 μs |   0.6419 μs |  0.0352 μs |  0.0203 μs |   6.463 μs |   6.529 μs | 154,119.4 |  2.02 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   7.022 μs |   1.5995 μs |  0.0877 μs |  0.0506 μs |   6.968 μs |   7.124 μs | 142,401.4 |  2.18 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   7.128 μs |   4.5037 μs |  0.2469 μs |  0.1425 μs |   6.881 μs |   7.375 μs | 140,286.9 |  2.22 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |   9.539 μs |   2.0952 μs |  0.1148 μs |  0.0663 μs |   9.424 μs |   9.653 μs | 104,837.8 |  2.96 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  31.362 μs |   2.4638 μs |  0.1351 μs |  0.0780 μs |  31.217 μs |  31.484 μs |  31,885.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.960 μs |   7.3172 μs |  0.4011 μs |  0.2316 μs |  32.584 μs |  33.382 μs |  30,339.6 |  1.05 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  64.197 μs |  23.2295 μs |  1.2733 μs |  0.7351 μs |  63.339 μs |  65.660 μs |  15,577.0 |  2.05 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  66.833 μs |  16.3835 μs |  0.8980 μs |  0.5185 μs |  66.133 μs |  67.846 μs |  14,962.6 |  2.13 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  77.697 μs |  77.3845 μs |  4.2417 μs |  2.4489 μs |  74.202 μs |  82.416 μs |  12,870.5 |  2.48 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 132.373 μs | 500.8594 μs | 27.4538 μs | 15.8505 μs | 106.100 μs | 160.872 μs |   7,554.4 |  4.22 |      56 B |          NA |
