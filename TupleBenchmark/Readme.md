# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 1.327 ns | 0.1110 ns | 0.0061 ns | 0.0035 ns | 1.323 ns | 1.334 ns | 753,339,291.0 |  0.97 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 1.377 ns | 2.8953 ns | 0.1587 ns | 0.0916 ns | 1.281 ns | 1.561 ns | 726,045,963.1 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.367 ns | 0.7605 ns | 0.0417 ns | 0.0241 ns | 4.321 ns | 4.403 ns | 228,981,552.8 |  3.20 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.301 ns | 0.1074 ns | 0.0059 ns | 0.0034 ns | 1.296 ns | 1.307 ns | 768,886,373.4 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 1.334 ns | 0.4151 ns | 0.0228 ns | 0.0131 ns | 1.319 ns | 1.361 ns | 749,404,397.1 |  1.03 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.325 ns | 0.1717 ns | 0.0094 ns | 0.0054 ns | 4.319 ns | 4.336 ns | 231,197,917.9 |  3.33 | 0.0051 |      32 B |          NA |
