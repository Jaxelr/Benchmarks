# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.200
  [Host]  : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2836 ns | 0.0232 ns | 0.1164 ns | 0.0070 ns | 0.0766 ns | 0.5714 ns | 3,525,521,214.4 |          - |         - |
| IncrementInterlocked | 7.6332 ns | 0.0020 ns | 0.0096 ns | 0.0006 ns | 7.6142 ns | 7.6748 ns |   131,006,121.0 |          - |         - |
