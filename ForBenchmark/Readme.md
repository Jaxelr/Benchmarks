# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithIncrementBy1           | 1         | 10000      |   2.588 μs |  0.8821 μs | 0.0483 μs | 0.0279 μs |   2.532 μs |   2.618 μs | 386,426.4 |  1.00 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |   3.244 μs |  0.4881 μs | 0.0268 μs | 0.0154 μs |   3.219 μs |   3.272 μs | 308,246.8 |  1.25 |         - |          NA |
| ForWithCustomIncrement        | 1         | 10000      |   3.268 μs |  0.3074 μs | 0.0169 μs | 0.0097 μs |   3.256 μs |   3.287 μs | 305,977.4 |  1.26 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |   3.279 μs |  0.1787 μs | 0.0098 μs | 0.0057 μs |   3.271 μs |   3.290 μs | 305,007.4 |  1.27 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |   6.320 μs |  0.5582 μs | 0.0306 μs | 0.0177 μs |   6.286 μs |   6.345 μs | 158,218.7 |  2.44 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  18.320 μs |  3.1630 μs | 0.1734 μs | 0.1001 μs |  18.124 μs |  18.452 μs |  54,584.9 |  7.08 |      56 B |          NA |
|                               |           |            |            |            |           |           |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  24.817 μs |  1.8429 μs | 0.1010 μs | 0.0583 μs |  24.701 μs |  24.887 μs |  40,295.7 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.019 μs |  0.3951 μs | 0.0217 μs | 0.0125 μs |  32.000 μs |  32.043 μs |  31,231.2 |  1.29 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     |  32.605 μs |  6.6009 μs | 0.3618 μs | 0.2089 μs |  32.292 μs |  33.001 μs |  30,670.2 |  1.31 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     |  33.110 μs |  8.6565 μs | 0.4745 μs | 0.2739 μs |  32.686 μs |  33.623 μs |  30,202.3 |  1.33 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     |  66.163 μs | 35.8334 μs | 1.9642 μs | 1.1340 μs |  63.939 μs |  67.661 μs |  15,114.1 |  2.67 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 183.109 μs | 53.8929 μs | 2.9541 μs | 1.7055 μs | 180.192 μs | 186.098 μs |   5,461.2 |  7.38 |      56 B |          NA |
