# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0589 ns | 0.7014 ns | 0.0384 ns | 0.0222 ns | 0.0218 ns | 0.0986 ns | 16,976,477,403.5 |  0.56 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.1117 ns | 0.6074 ns | 0.0333 ns | 0.0192 ns | 0.0898 ns | 0.1500 ns |  8,948,842,849.2 |  1.05 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.9389 ns | 1.1240 ns | 0.0616 ns | 0.0356 ns | 4.8736 ns | 4.9960 ns |    202,472,281.4 | 46.56 | 0.0076 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                  |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0498 ns | 0.1626 ns | 0.0089 ns | 0.0051 ns | 0.0398 ns | 0.0571 ns | 20,094,479,688.6 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.3257 ns | 0.1196 ns | 0.0066 ns | 0.0038 ns | 4.3190 ns | 4.3321 ns |    231,179,002.4 |     ? | 0.0077 |      32 B |           ? |
