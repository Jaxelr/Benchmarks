# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |     ? |      - |         - |           ? |
| ValueTuple | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 4.2966 ns | 4.5813 ns | 0.2511 ns | 0.1450 ns | 4.1377 ns | 4.5861 ns |    232,742,958.0 |     ? | 0.0076 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                  |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0319 ns | 0.5438 ns | 0.0298 ns | 0.0172 ns | 0.0000 ns | 0.0590 ns | 31,315,138,628.6 |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.1584 ns | 1.3527 ns | 0.0741 ns | 0.0428 ns | 0.1115 ns | 0.2439 ns |  6,312,914,979.0 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.8730 ns | 9.7459 ns | 0.5342 ns | 0.3084 ns | 4.5184 ns | 5.4874 ns |    205,211,303.5 |     ? | 0.0076 |      32 B |           ? |
