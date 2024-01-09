# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   3.276 μs |   0.8391 μs |  0.0460 μs | 0.0266 μs |   3.224 μs |   3.310 μs | 305,261.8 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.309 μs |   0.7411 μs |  0.0406 μs | 0.0235 μs |   3.276 μs |   3.354 μs | 302,215.7 |  1.01 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   7.145 μs |   4.1937 μs |  0.2299 μs | 0.1327 μs |   6.895 μs |   7.347 μs | 139,964.2 |  2.18 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   8.150 μs |  10.8284 μs |  0.5935 μs | 0.3427 μs |   7.547 μs |   8.733 μs | 122,696.9 |  2.49 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   9.188 μs |  39.1265 μs |  2.1447 μs | 1.2382 μs |   7.500 μs |  11.601 μs | 108,840.2 |  2.81 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  11.655 μs |  21.1099 μs |  1.1571 μs | 0.6681 μs |  10.412 μs |  12.701 μs |  85,798.2 |  3.56 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  31.840 μs |   5.7390 μs |  0.3146 μs | 0.1816 μs |  31.486 μs |  32.087 μs |  31,407.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.809 μs |   5.4190 μs |  0.2970 μs | 0.1715 μs |  32.551 μs |  33.134 μs |  30,479.3 |  1.03 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  74.890 μs |  33.5812 μs |  1.8407 μs | 1.0627 μs |  73.157 μs |  76.823 μs |  13,352.9 |  2.35 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  81.169 μs |  89.8992 μs |  4.9277 μs | 2.8450 μs |  75.481 μs |  84.147 μs |  12,320.0 |  2.55 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  85.144 μs | 246.9553 μs | 13.5365 μs | 7.8153 μs |  72.616 μs |  99.502 μs |  11,744.8 |  2.68 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 112.121 μs |  90.7132 μs |  4.9723 μs | 2.8708 μs | 106.625 μs | 116.309 μs |   8,918.9 |  3.52 |      56 B |          NA |
