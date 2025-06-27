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
| Method     | item1 | item2                | Mean     | Error      | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|-----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 1.761 ns |  0.0542 ns | 0.0030 ns | 0.0017 ns | 1.758 ns | 1.764 ns | 567,706,615.9 |  0.71 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 2.477 ns |  3.6230 ns | 0.1986 ns | 0.1147 ns | 2.266 ns | 2.661 ns | 403,641,520.4 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 7.495 ns | 18.2104 ns | 0.9982 ns | 0.5763 ns | 6.353 ns | 8.201 ns | 133,420,611.0 |  3.04 | 0.0051 |      32 B |          NA |
|            |       |                      |          |            |           |           |          |          |               |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 1.816 ns |  0.5467 ns | 0.0300 ns | 0.0173 ns | 1.798 ns | 1.851 ns | 550,646,170.3 |  0.99 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.840 ns |  0.2089 ns | 0.0114 ns | 0.0066 ns | 1.828 ns | 1.851 ns | 543,471,261.8 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 5.132 ns |  1.9723 ns | 0.1081 ns | 0.0624 ns | 5.048 ns | 5.254 ns | 194,871,153.8 |  2.79 | 0.0051 |      32 B |          NA |
