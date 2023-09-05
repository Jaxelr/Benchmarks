# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |      Error |    StdDev |    StdErr |      Min |      Max |          Op/s | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|-----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| TupleSruct |     4 |          Random Text | 2.070 ns |  1.3180 ns | 0.0722 ns | 0.0417 ns | 1.998 ns | 2.142 ns | 483,082,972.4 |  1.00 |      - |         - |          NA |
| ValueTuple |     4 |          Random Text | 2.147 ns |  4.3425 ns | 0.2380 ns | 0.1374 ns | 1.912 ns | 2.388 ns | 465,777,761.7 |  1.04 |      - |         - |          NA |
| TupleClass |     4 |          Random Text | 8.974 ns |  9.4076 ns | 0.5157 ns | 0.2977 ns | 8.382 ns | 9.327 ns | 111,437,616.9 |  4.34 | 0.0051 |      32 B |          NA |
|            |       |                      |          |            |           |           |          |          |               |       |        |           |             |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 2.041 ns |  4.6860 ns | 0.2569 ns | 0.1483 ns | 1.768 ns | 2.278 ns | 489,839,703.9 |  1.00 |      - |         - |          NA |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 2.054 ns |  0.2732 ns | 0.0150 ns | 0.0086 ns | 2.038 ns | 2.068 ns | 486,737,530.4 |  1.02 |      - |         - |          NA |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 7.640 ns | 17.5428 ns | 0.9616 ns | 0.5552 ns | 6.575 ns | 8.445 ns | 130,889,742.9 |  3.78 | 0.0051 |      32 B |          NA |
