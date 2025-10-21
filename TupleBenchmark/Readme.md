# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| TupleSruct | 4     | Random Text          | 0.0494 ns | 1.1365 ns | 0.0623 ns | 0.0360 ns | 0.0000 ns | 0.1194 ns |  20,256,069,302.2 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.1771 ns | 0.8977 ns | 0.0492 ns | 0.0284 ns | 3.1347 ns | 3.2311 ns |     314,750,363.5 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0078 ns | 0.0123 ns | 0.0007 ns | 0.0004 ns | 0.0070 ns | 0.0082 ns | 129,020,357,915.3 |     ? |      - |         - |           ? |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0257 ns | 0.7487 ns | 0.0410 ns | 0.0237 ns | 0.0000 ns | 0.0730 ns |  38,963,075,025.0 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.4252 ns | 0.5890 ns | 0.0323 ns | 0.0186 ns | 3.3978 ns | 3.4608 ns |     291,952,947.1 |     ? | 0.0077 |      32 B |           ? |
