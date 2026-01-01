# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio  | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0051 ns | 0.1005 ns | 0.0055 ns | 0.0032 ns | 0.0003 ns | 0.0111 ns | 195,871,568,808.7 |   1.36 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.0809 ns | 2.4690 ns | 0.1353 ns | 0.0781 ns | 0.0020 ns | 0.2371 ns |  12,367,960,707.9 |  21.53 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 3.1172 ns | 1.9390 ns | 0.1063 ns | 0.0614 ns | 3.0516 ns | 3.2399 ns |     320,796,694.5 | 830.24 | 0.0077 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                   |        |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0184 ns | 0.5808 ns | 0.0318 ns | 0.0184 ns | 0.0000 ns | 0.0551 ns |  54,405,056,596.9 |      ? |      - |         - |           ? |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0322 ns | 0.8179 ns | 0.0448 ns | 0.0259 ns | 0.0000 ns | 0.0834 ns |  31,084,688,721.3 |      ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.5201 ns | 0.0611 ns | 0.0034 ns | 0.0019 ns | 3.5170 ns | 3.5237 ns |     284,082,352.1 |      ? | 0.0077 |      32 B |           ? |
