# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.498 μs |  0.1008 μs | 0.0055 μs | 0.0032 μs |   2.494 μs |   2.504 μs | 400,358.1 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.213 μs |  0.2895 μs | 0.0159 μs | 0.0092 μs |   3.200 μs |   3.231 μs | 311,202.0 |  1.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.265 μs |  0.3015 μs | 0.0165 μs | 0.0095 μs |   3.249 μs |   3.282 μs | 306,277.9 |  1.31 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.307 μs |  0.7404 μs | 0.0406 μs | 0.0234 μs |   3.280 μs |   3.353 μs | 302,434.1 |  1.32 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.274 μs |  1.3007 μs | 0.0713 μs | 0.0412 μs |   6.222 μs |   6.355 μs | 159,400.5 |  2.51 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  19.245 μs |  6.6454 μs | 0.3643 μs | 0.2103 μs |  18.843 μs |  19.554 μs |  51,962.1 |  7.70 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  26.158 μs |  9.8235 μs | 0.5385 μs | 0.3109 μs |  25.774 μs |  26.774 μs |  38,228.9 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.184 μs |  0.6212 μs | 0.0341 μs | 0.0197 μs |  32.148 μs |  32.215 μs |  31,071.3 |  1.23 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  33.836 μs | 14.1480 μs | 0.7755 μs | 0.4477 μs |  33.194 μs |  34.698 μs |  29,554.3 |  1.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  33.976 μs |  8.1353 μs | 0.4459 μs | 0.2575 μs |  33.470 μs |  34.312 μs |  29,432.5 |  1.30 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  63.578 μs | 19.7440 μs | 1.0822 μs | 0.6248 μs |  62.460 μs |  64.621 μs |  15,728.6 |  2.43 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 191.852 μs | 74.8363 μs | 4.1020 μs | 2.3683 μs | 188.791 μs | 196.513 μs |   5,212.4 |  7.34 |      56 B |          NA |
