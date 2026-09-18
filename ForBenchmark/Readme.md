# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr     | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   3.007 μs |   0.5226 μs |  0.0286 μs |  0.0165 μs |   2.978 μs |   3.036 μs | 332,546.9 |  0.96 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   3.126 μs |   1.1108 μs |  0.0609 μs |  0.0352 μs |   3.056 μs |   3.165 μs | 319,922.1 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  20.917 μs |   2.3658 μs |  0.1297 μs |  0.0749 μs |  20.778 μs |  21.035 μs |  47,808.9 |  6.69 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  22.859 μs |  12.0154 μs |  0.6586 μs |  0.3802 μs |  22.398 μs |  23.614 μs |  43,745.6 |  7.32 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  24.730 μs |   0.8046 μs |  0.0441 μs |  0.0255 μs |  24.685 μs |  24.773 μs |  40,436.2 |  7.91 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  26.291 μs |  13.0507 μs |  0.7154 μs |  0.4130 μs |  25.513 μs |  26.919 μs |  38,035.1 |  8.41 |         - |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
| ForWithIncrementBy1           | 1         | 100000     |  29.515 μs |   1.0890 μs |  0.0597 μs |  0.0345 μs |  29.480 μs |  29.584 μs |  33,880.7 |  1.00 |         - |          NA |
| ForWithCustomIncrement        | 1         | 100000     |  32.642 μs |  32.1747 μs |  1.7636 μs |  1.0182 μs |  30.906 μs |  34.432 μs |  30,635.6 |  1.11 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 208.976 μs |  61.7779 μs |  3.3863 μs |  1.9551 μs | 206.873 μs | 212.882 μs |   4,785.2 |  7.08 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 216.011 μs |  54.1673 μs |  2.9691 μs |  1.7142 μs | 214.271 μs | 219.439 μs |   4,629.4 |  7.32 |      56 B |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 252.015 μs |  51.1539 μs |  2.8039 μs |  1.6188 μs | 248.785 μs | 253.830 μs |   3,968.0 |  8.54 |         - |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 268.320 μs | 326.5625 μs | 17.9000 μs | 10.3346 μs | 247.802 μs | 280.742 μs |   3,726.9 |  9.09 |         - |          NA |
