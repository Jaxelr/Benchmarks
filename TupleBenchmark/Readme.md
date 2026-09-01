# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0056 ns | 0.1479 ns | 0.0081 ns | 0.0047 ns | 0.0000 ns | 0.0149 ns | 177,395,886,862.3 |     ? |      - |         - |           ? |
| TupleSruct | 4     | Random Text          | 0.0058 ns | 0.1022 ns | 0.0056 ns | 0.0032 ns | 0.0000 ns | 0.0112 ns | 171,139,689,940.6 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 4.3846 ns | 2.3111 ns | 0.1267 ns | 0.0731 ns | 4.2627 ns | 4.5156 ns |     228,071,989.9 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0189 ns | 0.0166 ns | 0.0009 ns | 0.0005 ns | 0.0179 ns | 0.0197 ns |  52,780,498,176.3 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.8822 ns | 0.9046 ns | 0.0496 ns | 0.0286 ns | 3.8297 ns | 3.9282 ns |     257,584,815.8 |     ? | 0.0077 |      32 B |           ? |
