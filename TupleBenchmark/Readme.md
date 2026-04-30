# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3  RatioSD=?

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.0003 ns | 0.0104 ns | 0.0006 ns | 0.0003 ns | 0.0000 ns | 0.0010 ns | 3,047,517,002,838.2 |     ? |      - |         - |           ? |
| ValueTuple | 4     | Random Text          | 0.0025 ns | 0.0116 ns | 0.0006 ns | 0.0004 ns | 0.0019 ns | 0.0031 ns |   405,471,208,901.9 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.7050 ns | 1.1115 ns | 0.0609 ns | 0.0352 ns | 3.6443 ns | 3.7662 ns |       269,906,663.2 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                     |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0006 ns | 0.0096 ns | 0.0005 ns | 0.0003 ns | 0.0000 ns | 0.0010 ns | 1,699,317,087,993.2 |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0037 ns | 0.0691 ns | 0.0038 ns | 0.0022 ns | 0.0000 ns | 0.0076 ns |   268,627,972,713.8 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.6588 ns | 0.4411 ns | 0.0242 ns | 0.0140 ns | 3.6309 ns | 3.6744 ns |       273,313,704.8 |     ? | 0.0077 |      32 B |           ? |
