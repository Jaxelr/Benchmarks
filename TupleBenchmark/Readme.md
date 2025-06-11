# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 1.319 ns |  1.515 ns | 0.0831 ns | 0.0480 ns | 1.224 ns | 1.377 ns | 758,216,569.7 |  0.75 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 1.987 ns | 16.432 ns | 0.9007 ns | 0.5200 ns | 1.419 ns | 3.025 ns | 503,363,544.5 |  1.12 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 6.720 ns | 18.579 ns | 1.0184 ns | 0.5880 ns | 5.574 ns | 7.522 ns | 148,817,256.4 |  3.80 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.115 ns |  3.037 ns | 0.1664 ns | 0.0961 ns | 1.017 ns | 1.307 ns | 896,950,840.1 |  1.01 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 1.517 ns |  2.876 ns | 0.1576 ns | 0.0910 ns | 1.366 ns | 1.681 ns | 658,990,292.1 |  1.38 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 6.209 ns | 24.040 ns | 1.3177 ns | 0.7608 ns | 5.097 ns | 7.665 ns | 161,054,754.1 |  5.65 | 0.0051 |      32 B |          NA |
