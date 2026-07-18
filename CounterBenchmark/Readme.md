# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]  : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.4530 ns | 0.0318 ns | 0.1608 ns | 0.0096 ns | 0.2571 ns | 0.8437 ns | 2,207,319,990.3 |          - |         - |
| IncrementInterlocked | 7.6594 ns | 0.0066 ns | 0.0330 ns | 0.0020 ns | 7.5917 ns | 7.7635 ns |   130,558,686.2 |          - |         - |
