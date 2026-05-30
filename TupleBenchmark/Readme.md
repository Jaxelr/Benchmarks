# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.0007 ns | 0.0234 ns | 0.0013 ns | 0.0007 ns | 0.0000 ns | 0.0022 ns | 1,349,487,001,256.8 |     ? |      - |         - |           ? |
| ValueTuple | 4     | Random Text          | 0.0026 ns | 0.0133 ns | 0.0007 ns | 0.0004 ns | 0.0020 ns | 0.0034 ns |   388,370,846,133.4 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.8143 ns | 0.7296 ns | 0.0400 ns | 0.0231 ns | 3.7868 ns | 3.8602 ns |       262,173,562.8 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                     |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0015 ns | 0.0339 ns | 0.0019 ns | 0.0011 ns | 0.0000 ns | 0.0036 ns |   666,010,311,375.8 |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0973 ns | 2.1855 ns | 0.1198 ns | 0.0692 ns | 0.0281 ns | 0.2356 ns |    10,276,031,285.9 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 2.7534 ns | 0.9110 ns | 0.0499 ns | 0.0288 ns | 2.7009 ns | 2.8003 ns |       363,191,255.6 |     ? | 0.0077 |      32 B |           ? |
