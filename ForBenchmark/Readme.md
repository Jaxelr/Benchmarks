# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean      | Error       | StdDev     | StdErr    | Min       | Max       | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |  3.213 μs |   0.0651 μs |  0.0036 μs | 0.0021 μs |  3.210 μs |  3.217 μs | 311,215.1 |  0.76 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |  4.249 μs |   0.2769 μs |  0.0152 μs | 0.0088 μs |  4.235 μs |  4.265 μs | 235,342.1 |  1.00 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  6.265 μs |   0.3020 μs |  0.0166 μs | 0.0096 μs |  6.246 μs |  6.277 μs | 159,618.3 |  1.47 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  6.518 μs |   2.1334 μs |  0.1169 μs | 0.0675 μs |  6.411 μs |  6.643 μs | 153,415.6 |  1.53 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  6.776 μs |   2.4789 μs |  0.1359 μs | 0.0784 μs |  6.620 μs |  6.869 μs | 147,577.0 |  1.59 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  9.901 μs |   6.9013 μs |  0.3783 μs | 0.2184 μs |  9.614 μs | 10.330 μs | 100,995.5 |  2.33 |      56 B |          NA |
|                               |           |            |           |             |            |           |           |           |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     | 31.004 μs |   2.0875 μs |  0.1144 μs | 0.0661 μs | 30.876 μs | 31.098 μs |  32,254.1 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     | 32.033 μs |   0.9456 μs |  0.0518 μs | 0.0299 μs | 31.997 μs | 32.093 μs |  31,217.7 |  1.03 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 62.994 μs |  27.6934 μs |  1.5180 μs | 0.8764 μs | 61.879 μs | 64.723 μs |  15,874.6 |  2.03 |      40 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 65.718 μs |   5.6327 μs |  0.3087 μs | 0.1783 μs | 65.369 μs | 65.958 μs |  15,216.6 |  2.12 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 82.391 μs | 243.4780 μs | 13.3459 μs | 7.7052 μs | 71.406 μs | 97.243 μs |  12,137.3 |  2.66 |         - |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 93.516 μs |  42.9697 μs |  2.3553 μs | 1.3598 μs | 92.054 μs | 96.233 μs |  10,693.3 |  3.02 |      56 B |          NA |
