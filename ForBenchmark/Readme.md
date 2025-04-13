# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   4.583 μs |   0.5725 μs |  0.0314 μs | 0.0181 μs |   4.553 μs |   4.616 μs | 218,200.2 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   4.906 μs |   2.6911 μs |  0.1475 μs | 0.0852 μs |   4.762 μs |   5.057 μs | 203,817.3 |  1.07 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   5.144 μs |   1.1812 μs |  0.0647 μs | 0.0374 μs |   5.097 μs |   5.218 μs | 194,386.1 |  1.12 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   5.647 μs |   1.7013 μs |  0.0933 μs | 0.0538 μs |   5.575 μs |   5.752 μs | 177,091.4 |  1.23 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  15.626 μs |  16.9640 μs |  0.9299 μs | 0.5369 μs |  14.599 μs |  16.410 μs |  63,995.3 |  3.41 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  35.323 μs |   2.7973 μs |  0.1533 μs | 0.0885 μs |  35.207 μs |  35.497 μs |  28,310.4 |  7.71 |      56 B |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  44.294 μs |   7.5400 μs |  0.4133 μs | 0.2386 μs |  43.842 μs |  44.653 μs |  22,576.6 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  48.330 μs |  23.2437 μs |  1.2741 μs | 0.7356 μs |  47.333 μs |  49.766 μs |  20,691.0 |  1.09 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  49.256 μs |  65.9676 μs |  3.6159 μs | 2.0876 μs |  46.224 μs |  53.258 μs |  20,302.1 |  1.11 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  58.141 μs |  35.3907 μs |  1.9399 μs | 1.1200 μs |  56.827 μs |  60.369 μs |  17,199.4 |  1.31 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 133.196 μs | 300.7775 μs | 16.4866 μs | 9.5186 μs | 115.510 μs | 148.138 μs |   7,507.7 |  3.01 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 246.698 μs |  21.0018 μs |  1.1512 μs | 0.6646 μs | 245.461 μs | 247.738 μs |   4,053.5 |  5.57 |      56 B |          NA |
