# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   3.218 μs |   1.1599 μs |  0.0636 μs |  0.0367 μs |   3.168 μs |   3.289 μs | 310,783.1 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.257 μs |   0.3040 μs |  0.0167 μs |  0.0096 μs |   3.240 μs |   3.273 μs | 307,061.0 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.933 μs |  10.1249 μs |  0.5550 μs |  0.3204 μs |   6.568 μs |   7.571 μs | 144,247.9 |  2.16 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   7.191 μs |   1.8482 μs |  0.1013 μs |  0.0585 μs |   7.075 μs |   7.256 μs | 139,054.8 |  2.24 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   7.405 μs |   2.7993 μs |  0.1534 μs |  0.0886 μs |   7.291 μs |   7.580 μs | 135,035.6 |  2.30 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  10.561 μs |  15.3205 μs |  0.8398 μs |  0.4848 μs |   9.593 μs |  11.093 μs |  94,688.9 |  3.28 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  31.617 μs |   8.1202 μs |  0.4451 μs |  0.2570 μs |  31.107 μs |  31.923 μs |  31,628.2 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  33.198 μs |  13.1359 μs |  0.7200 μs |  0.4157 μs |  32.547 μs |  33.971 μs |  30,122.2 |  1.05 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  68.215 μs |  37.8640 μs |  2.0755 μs |  1.1983 μs |  66.212 μs |  70.356 μs |  14,659.5 |  2.16 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  68.617 μs |  44.0377 μs |  2.4139 μs |  1.3936 μs |  66.825 μs |  71.362 μs |  14,573.6 |  2.17 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 151.760 μs | 415.1683 μs | 22.7568 μs | 13.1386 μs | 132.865 μs | 177.022 μs |   6,589.4 |  4.80 |      56 B |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 191.027 μs | 687.9036 μs | 37.7063 μs | 21.7698 μs | 158.209 μs | 232.215 μs |   5,234.9 |  6.03 |      40 B |          NA |
