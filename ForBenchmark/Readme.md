# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.475 μs |  0.0850 μs | 0.0047 μs | 0.0027 μs |   2.472 μs |   2.481 μs | 403,997.5 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.191 μs |  0.0773 μs | 0.0042 μs | 0.0024 μs |   3.186 μs |   3.195 μs | 313,376.4 |  1.29 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.208 μs |  0.1413 μs | 0.0077 μs | 0.0045 μs |   3.202 μs |   3.217 μs | 311,730.1 |  1.30 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.220 μs |  0.7083 μs | 0.0388 μs | 0.0224 μs |   3.195 μs |   3.265 μs | 310,514.7 |  1.30 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.650 μs |  5.9970 μs | 0.3287 μs | 0.1898 μs |   6.451 μs |   7.029 μs | 150,384.7 |  2.69 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  17.846 μs |  2.1396 μs | 0.1173 μs | 0.0677 μs |  17.752 μs |  17.977 μs |  56,035.4 |  7.21 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  24.656 μs |  2.1437 μs | 0.1175 μs | 0.0678 μs |  24.569 μs |  24.790 μs |  40,557.5 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  31.934 μs |  0.6417 μs | 0.0352 μs | 0.0203 μs |  31.894 μs |  31.960 μs |  31,314.9 |  1.30 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  32.017 μs |  2.6205 μs | 0.1436 μs | 0.0829 μs |  31.875 μs |  32.163 μs |  31,233.3 |  1.30 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.645 μs | 10.8665 μs | 0.5956 μs | 0.3439 μs |  32.025 μs |  33.213 μs |  30,632.8 |  1.32 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  62.578 μs |  8.7309 μs | 0.4786 μs | 0.2763 μs |  62.035 μs |  62.938 μs |  15,980.0 |  2.54 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 183.441 μs | 57.2071 μs | 3.1357 μs | 1.8104 μs | 180.761 μs | 186.889 μs |   5,451.3 |  7.44 |      56 B |          NA |
