# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |      Error |    StdDev |    StdErr |      Min |      Max |          Op/s | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|-----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple |     4 |          Random Text | 1.844 ns |  0.3814 ns | 0.0209 ns | 0.0121 ns | 1.831 ns | 1.868 ns | 542,424,945.7 |  0.96 |      - |         - |          NA |
| TupleSruct |     4 |          Random Text | 1.926 ns |  2.0656 ns | 0.1132 ns | 0.0654 ns | 1.836 ns | 2.053 ns | 519,248,550.8 |  1.00 |      - |         - |          NA |
| TupleClass |     4 |          Random Text | 5.328 ns |  1.9047 ns | 0.1044 ns | 0.0603 ns | 5.210 ns | 5.408 ns | 187,679,846.1 |  2.77 | 0.0051 |      32 B |          NA |
|            |       |                      |          |            |           |           |          |          |               |       |        |           |             |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 1.837 ns |  1.1222 ns | 0.0615 ns | 0.0355 ns | 1.777 ns | 1.900 ns | 544,441,222.0 |  1.00 |      - |         - |          NA |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 2.149 ns |  4.0149 ns | 0.2201 ns | 0.1271 ns | 1.932 ns | 2.372 ns | 465,373,152.6 |  1.17 |      - |         - |          NA |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 5.938 ns | 20.3630 ns | 1.1162 ns | 0.6444 ns | 5.294 ns | 7.227 ns | 168,395,335.0 |  3.22 | 0.0051 |      32 B |          NA |
