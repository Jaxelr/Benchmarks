# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean     | Error      | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|-----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 1.880 ns |  0.6164 ns | 0.0338 ns | 0.0195 ns | 1.856 ns | 1.919 ns | 531,856,779.0 |  0.83 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 2.288 ns |  4.3815 ns | 0.2402 ns | 0.1387 ns | 2.050 ns | 2.530 ns | 436,972,075.0 |  1.01 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 8.067 ns | 17.5046 ns | 0.9595 ns | 0.5540 ns | 7.241 ns | 9.119 ns | 123,959,165.0 |  3.55 | 0.0051 |      32 B |          NA |
|            |       |                      |          |            |           |           |          |          |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.889 ns |  1.3119 ns | 0.0719 ns | 0.0415 ns | 1.832 ns | 1.970 ns | 529,324,230.6 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 2.530 ns |  4.1619 ns | 0.2281 ns | 0.1317 ns | 2.287 ns | 2.739 ns | 395,192,871.3 |  1.34 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 7.722 ns | 20.3528 ns | 1.1156 ns | 0.6441 ns | 6.918 ns | 8.995 ns | 129,505,664.4 |  4.09 | 0.0051 |      32 B |          NA |
