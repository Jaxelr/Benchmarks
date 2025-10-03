# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6584)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.3315 ns | 0.0332 ns | 0.1701 ns | 0.0100 ns | 0.0819 ns | 0.9388 ns | 3,017,015,522.9 |          - |         - |
| IncrementInterlocked | 7.8682 ns | 0.0022 ns | 0.0112 ns | 0.0007 ns | 7.8485 ns | 7.9049 ns |   127,093,151.8 |          - |         - |
