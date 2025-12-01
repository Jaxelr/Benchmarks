# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio     | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|----------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     0.000 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.0377 ns | 1.1361 ns | 0.0623 ns | 0.0360 ns | 0.0008 ns | 0.1096 ns |  26,530,616,972.8 |    19.709 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 3.4789 ns | 0.6695 ns | 0.0367 ns | 0.0212 ns | 3.4366 ns | 3.5002 ns |     287,444,157.3 | 1,819.123 | 0.0077 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                   |           |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0098 ns | 0.1424 ns | 0.0078 ns | 0.0045 ns | 0.0019 ns | 0.0175 ns | 102,242,949,570.9 |      2.27 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0441 ns | 1.3936 ns | 0.0764 ns | 0.0441 ns | 0.0000 ns | 0.1323 ns |  22,675,169,238.8 |     10.24 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.3744 ns | 4.6877 ns | 0.2569 ns | 0.1483 ns | 4.2003 ns | 4.6695 ns |     228,604,128.1 |  1,015.39 | 0.0077 |      32 B |          NA |
