# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min       | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   4.479 μs |  1.4503 μs | 0.0795 μs | 0.0459 μs |  4.405 μs |   4.563 μs | 223,280.3 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   4.729 μs |  2.7662 μs | 0.1516 μs | 0.0875 μs |  4.621 μs |   4.902 μs | 211,457.2 |  1.06 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   7.162 μs |  3.0606 μs | 0.1678 μs | 0.0969 μs |  6.995 μs |   7.330 μs | 139,618.5 |  1.60 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   7.787 μs |  9.5556 μs | 0.5238 μs | 0.3024 μs |  7.355 μs |   8.370 μs | 128,421.2 |  1.74 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   8.974 μs | 15.5670 μs | 0.8533 μs | 0.4926 μs |  8.097 μs |   9.801 μs | 111,426.8 |  2.01 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  11.819 μs | 15.1281 μs | 0.8292 μs | 0.4788 μs | 10.931 μs |  12.572 μs |  84,609.0 |  2.64 |      56 B |          NA |
|                               |           |            |            |            |           |           |           |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  31.898 μs | 13.7464 μs | 0.7535 μs | 0.4350 μs | 31.311 μs |  32.747 μs |  31,350.4 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.538 μs |  0.6593 μs | 0.0361 μs | 0.0209 μs | 32.509 μs |  32.578 μs |  30,733.5 |  1.02 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  66.431 μs | 72.9256 μs | 3.9973 μs | 2.3078 μs | 62.729 μs |  70.670 μs |  15,053.2 |  2.08 |      40 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  71.200 μs | 23.5974 μs | 1.2935 μs | 0.7468 μs | 70.156 μs |  72.647 μs |  14,045.0 |  2.23 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  73.959 μs |  9.2430 μs | 0.5066 μs | 0.2925 μs | 73.490 μs |  74.496 μs |  13,521.1 |  2.32 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 100.445 μs | 10.0735 μs | 0.5522 μs | 0.3188 μs | 99.945 μs | 101.038 μs |   9,955.7 |  3.15 |      56 B |          NA |
