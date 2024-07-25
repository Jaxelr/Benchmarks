# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          |  2.471 ns |  7.368 ns | 0.4039 ns | 0.2332 ns |  2.093 ns |  2.897 ns | 404,672,926.8 |  0.87 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          |  2.838 ns |  5.764 ns | 0.3159 ns | 0.1824 ns |  2.530 ns |  3.161 ns | 352,336,871.5 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 11.545 ns |  6.281 ns | 0.3443 ns | 0.1988 ns | 11.236 ns | 11.916 ns |  86,616,953.8 |  4.10 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX |  3.244 ns | 10.631 ns | 0.5827 ns | 0.3364 ns |  2.629 ns |  3.788 ns | 308,301,454.6 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX |  3.590 ns |  4.256 ns | 0.2333 ns | 0.1347 ns |  3.321 ns |  3.740 ns | 278,568,602.5 |  1.14 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 13.739 ns | 24.120 ns | 1.3221 ns | 0.7633 ns | 12.538 ns | 15.155 ns |  72,786,249.7 |  4.34 | 0.0051 |      32 B |          NA |
