# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]  : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2893 ns | 0.0060 ns | 0.0303 ns | 0.0018 ns | 0.2440 ns | 0.3717 ns | 3,457,038,546.6 |          - |         - |
| IncrementInterlocked | 7.6088 ns | 0.0086 ns | 0.0413 ns | 0.0026 ns | 7.5363 ns | 7.7488 ns |   131,426,348.2 |          - |         - |
