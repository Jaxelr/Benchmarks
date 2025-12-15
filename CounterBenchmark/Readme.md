# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]  : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2853 ns | 0.0040 ns | 0.0204 ns | 0.0012 ns | 0.2519 ns | 0.3064 ns | 3,504,896,186.6 |          - |         - |
| IncrementInterlocked | 7.6209 ns | 0.0042 ns | 0.0212 ns | 0.0013 ns | 7.5772 ns | 7.6652 ns |   131,218,205.0 |          - |         - |
