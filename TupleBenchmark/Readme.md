# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| TupleSruct | 4     | Random Text          | 0.0011 ns | 0.0361 ns | 0.0020 ns | 0.0011 ns | 0.0000 ns | 0.0034 ns | 875,999,530,077.2 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.9802 ns | 1.0965 ns | 0.0601 ns | 0.0347 ns | 3.9119 ns | 4.0253 ns |     251,246,431.4 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0015 ns | 0.0239 ns | 0.0013 ns | 0.0008 ns | 0.0006 ns | 0.0030 ns | 647,196,309,571.6 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.9079 ns | 2.1094 ns | 0.1156 ns | 0.0668 ns | 3.7887 ns | 4.0196 ns |     255,891,175.8 |     ? | 0.0077 |      32 B |           ? |
