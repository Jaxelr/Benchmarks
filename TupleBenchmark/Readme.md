# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3  RatioSD=?

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.0034 ns | 0.1059 ns | 0.0058 ns | 0.0034 ns | 0.0000 ns | 0.0101 ns | 298,333,438,790.8 |     ? |      - |         - |           ? |
| ValueTuple | 4     | Random Text          | 0.2123 ns | 1.0477 ns | 0.0574 ns | 0.0332 ns | 0.1460 ns | 0.2468 ns |   4,709,862,196.8 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.2676 ns | 1.4894 ns | 0.0816 ns | 0.0471 ns | 3.2196 ns | 3.3618 ns |     306,037,486.2 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0373 ns | 0.0223 ns | 0.0012 ns | 0.0007 ns | 0.0361 ns | 0.0385 ns |  26,780,922,875.3 |     ? |      - |         - |           ? |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0577 ns | 1.2666 ns | 0.0694 ns | 0.0401 ns | 0.0000 ns | 0.1348 ns |  17,326,353,103.7 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.7189 ns | 0.4082 ns | 0.0224 ns | 0.0129 ns | 3.6984 ns | 3.7428 ns |     268,896,200.7 |     ? | 0.0077 |      32 B |           ? |
