# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.613 μs |  0.1922 μs | 0.0105 μs | 0.0061 μs |   2.603 μs |   2.624 μs | 382,754.0 |  1.00 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.221 μs |  0.1152 μs | 0.0063 μs | 0.0036 μs |   3.217 μs |   3.228 μs | 310,496.8 |  1.23 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.234 μs |  0.0666 μs | 0.0037 μs | 0.0021 μs |   3.230 μs |   3.236 μs | 309,240.6 |  1.24 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.241 μs |  0.9981 μs | 0.0547 μs | 0.0316 μs |   3.209 μs |   3.305 μs | 308,507.6 |  1.24 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.303 μs |  1.3377 μs | 0.0733 μs | 0.0423 μs |   6.225 μs |   6.371 μs | 158,665.0 |  2.41 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  17.923 μs |  0.3423 μs | 0.0188 μs | 0.0108 μs |  17.904 μs |  17.941 μs |  55,793.1 |  6.86 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  24.830 μs |  3.1649 μs | 0.1735 μs | 0.1002 μs |  24.685 μs |  25.022 μs |  40,274.5 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  32.055 μs |  1.9562 μs | 0.1072 μs | 0.0619 μs |  31.942 μs |  32.156 μs |  31,196.3 |  1.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  32.464 μs |  2.0471 μs | 0.1122 μs | 0.0648 μs |  32.377 μs |  32.590 μs |  30,803.5 |  1.31 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.494 μs |  5.7832 μs | 0.3170 μs | 0.1830 μs |  32.163 μs |  32.795 μs |  30,775.2 |  1.31 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  62.054 μs |  0.7182 μs | 0.0394 μs | 0.0227 μs |  62.021 μs |  62.097 μs |  16,115.1 |  2.50 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 180.785 μs | 38.9953 μs | 2.1375 μs | 1.2341 μs | 178.935 μs | 183.125 μs |   5,531.4 |  7.28 |      56 B |          NA |
