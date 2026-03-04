# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7922/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Ratio   | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|--------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0233 ns | 0.5427 ns | 0.0297 ns | 0.0172 ns | 0.0000 ns | 0.0568 ns | 42,880,149,943.6 |    0.56 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.0509 ns | 0.5160 ns | 0.0283 ns | 0.0163 ns | 0.0283 ns | 0.0826 ns | 19,660,224,016.9 |    1.21 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 3.6322 ns | 0.8024 ns | 0.0440 ns | 0.0254 ns | 3.5900 ns | 3.6778 ns |    275,316,100.9 |   86.49 | 0.0077 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                  |         |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |   0.000 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0221 ns | 0.0516 ns | 0.0028 ns | 0.0016 ns | 0.0196 ns | 0.0252 ns | 45,293,840,581.3 |   1.011 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.0318 ns | 1.1551 ns | 0.0633 ns | 0.0366 ns | 3.9745 ns | 4.0998 ns |    248,025,839.6 | 184.561 | 0.0077 |      32 B |          NA |
