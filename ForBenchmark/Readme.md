# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   4.229 μs |   0.9218 μs |  0.0505 μs |  0.0292 μs |   4.180 μs |   4.281 μs | 236,469.3 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   5.491 μs |   0.8477 μs |  0.0465 μs |  0.0268 μs |   5.449 μs |   5.541 μs | 182,113.8 |  1.30 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   5.742 μs |   0.3708 μs |  0.0203 μs |  0.0117 μs |   5.722 μs |   5.763 μs | 174,158.2 |  1.36 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   5.759 μs |   3.3551 μs |  0.1839 μs |  0.1062 μs |   5.609 μs |   5.964 μs | 173,648.2 |  1.36 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  12.308 μs |  12.3433 μs |  0.6766 μs |  0.3906 μs |  11.562 μs |  12.883 μs |  81,249.4 |  2.91 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  33.993 μs |  11.0263 μs |  0.6044 μs |  0.3489 μs |  33.297 μs |  34.382 μs |  29,417.9 |  8.04 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  39.566 μs |  24.4474 μs |  1.3400 μs |  0.7737 μs |  38.073 μs |  40.663 μs |  25,273.9 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  48.225 μs |  94.0993 μs |  5.1579 μs |  2.9779 μs |  44.887 μs |  54.166 μs |  20,736.0 |  1.22 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  48.256 μs |  32.7034 μs |  1.7926 μs |  1.0349 μs |  46.195 μs |  49.453 μs |  20,722.9 |  1.22 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  48.688 μs |  55.5574 μs |  3.0453 μs |  1.7582 μs |  46.409 μs |  52.147 μs |  20,538.8 |  1.23 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 161.120 μs | 474.1093 μs | 25.9875 μs | 15.0039 μs | 141.561 μs | 190.608 μs |   6,206.6 |  4.08 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 327.018 μs |  30.4107 μs |  1.6669 μs |  0.9624 μs | 325.755 μs | 328.907 μs |   3,057.9 |  8.27 |      56 B |          NA |
