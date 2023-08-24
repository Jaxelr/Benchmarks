# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                        Method | Increment | Iterations |       Mean |       Error |     StdDev |     StdErr |        Min |        Max |      Op/s | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|-----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
|           ForWithIncrementBy1 |         1 |      10000 |   4.962 μs |   0.8041 μs |  0.0441 μs |  0.0254 μs |   4.914 μs |   5.001 μs | 201,545.8 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |      10000 |   5.156 μs |   1.1090 μs |  0.0608 μs |  0.0351 μs |   5.104 μs |   5.223 μs | 193,933.2 |  1.04 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |      10000 |  15.083 μs |  33.3811 μs |  1.8297 μs |  1.0564 μs |  13.491 μs |  17.082 μs |  66,299.9 |  3.04 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |      10000 |  16.526 μs |   7.9399 μs |  0.4352 μs |  0.2513 μs |  16.030 μs |  16.845 μs |  60,511.9 |  3.33 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |      10000 |  49.215 μs |  17.5513 μs |  0.9620 μs |  0.5554 μs |  48.312 μs |  50.227 μs |  20,319.2 |  9.92 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |      10000 |  56.945 μs |  17.7417 μs |  0.9725 μs |  0.5615 μs |  56.025 μs |  57.963 μs |  17,560.8 | 11.48 |      56 B |          NA |
|                               |           |            |            |             |            |            |            |            |           |       |           |             |
|           ForWithIncrementBy1 |         1 |     100000 |  48.064 μs |   5.9345 μs |  0.3253 μs |  0.1878 μs |  47.740 μs |  48.390 μs |  20,805.7 |  1.00 |         - |          NA |
|        ForWithCustomIncrement |         1 |     100000 |  50.427 μs |  16.0325 μs |  0.8788 μs |  0.5074 μs |  49.458 μs |  51.174 μs |  19,830.8 |  1.05 |         - |          NA |
| ForeachWithRangeEnumeratorRaw |         1 |     100000 | 134.204 μs | 201.7165 μs | 11.0568 μs |  6.3836 μs | 122.574 μs | 144.581 μs |   7,451.4 |  2.79 |         - |          NA |
|    ForeachWithRangeEnumerator |         1 |     100000 | 150.704 μs | 128.7511 μs |  7.0573 μs |  4.0745 μs | 142.626 μs | 155.670 μs |   6,635.5 |  3.14 |         - |          NA |
|    ForeachWithEnumerableRange |         1 |     100000 | 529.658 μs | 692.0167 μs | 37.9318 μs | 21.8999 μs | 486.203 μs | 556.136 μs |   1,888.0 | 11.02 |      40 B |          NA |
|        ForeachWithYieldReturn |         1 |     100000 | 589.473 μs | 524.5274 μs | 28.7511 μs | 16.5995 μs | 559.699 μs | 617.079 μs |   1,696.4 | 12.26 |      56 B |          NA |
