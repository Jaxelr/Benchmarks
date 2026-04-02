# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3  RatioSD=?

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0006 ns | 0.0181 ns | 0.0010 ns | 0.0006 ns | 0.0000 ns | 0.0017 ns | 1,750,095,334,130.2 |     ? |      - |         - |           ? |
| TupleSruct | 4     | Random Text          | 0.0169 ns | 0.5348 ns | 0.0293 ns | 0.0169 ns | 0.0000 ns | 0.0508 ns |    59,085,973,557.2 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.7948 ns | 0.3171 ns | 0.0174 ns | 0.0100 ns | 3.7790 ns | 3.8134 ns |       263,519,223.8 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                     |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.8085 ns | 0.1780 ns | 0.0098 ns | 0.0056 ns | 3.7983 ns | 3.8177 ns |       262,567,783.7 |     ? | 0.0077 |      32 B |           ? |
