# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s            | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.9295 ns |  0.4973 ns | 0.0273 ns | 0.0157 ns | 0.9131 ns | 0.9609 ns | 1,075,903,385.6 |  0.90 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 1.0365 ns |  1.7551 ns | 0.0962 ns | 0.0555 ns | 0.9746 ns | 1.1473 ns |   964,792,906.6 |  1.01 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.7629 ns | 23.3977 ns | 1.2825 ns | 0.7405 ns | 3.9433 ns | 6.2409 ns |   209,957,613.6 |  4.62 | 0.0051 |      32 B |          NA |
|            |       |                      |           |            |           |           |           |           |                 |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.7836 ns |  0.1186 ns | 0.0065 ns | 0.0038 ns | 0.7797 ns | 0.7911 ns | 1,276,096,535.1 |  0.83 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.9599 ns |  2.9114 ns | 0.1596 ns | 0.0921 ns | 0.8393 ns | 1.1409 ns | 1,041,759,663.4 |  1.02 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.3181 ns |  3.6649 ns | 0.2009 ns | 0.1160 ns | 4.1033 ns | 4.5014 ns |   231,583,563.5 |  4.58 | 0.0051 |      32 B |          NA |
