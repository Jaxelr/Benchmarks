# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]  : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.3637 ns | 0.0274 ns | 0.1324 ns | 0.0082 ns | 0.2399 ns | 0.5622 ns | 2,749,548,184.0 |          - |         - |
| IncrementInterlocked | 7.6953 ns | 0.0252 ns | 0.1182 ns | 0.0076 ns | 7.5747 ns | 7.8989 ns |   129,950,240.4 |          - |         - |
