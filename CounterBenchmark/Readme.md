# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]  : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.4037 ns | 0.0225 ns | 0.1169 ns | 0.0068 ns | 0.2218 ns | 0.7537 ns | 2,477,300,630.6 |          - |         - |
| IncrementInterlocked | 7.6475 ns | 0.0073 ns | 0.0355 ns | 0.0022 ns | 7.5926 ns | 7.7711 ns |   130,761,476.3 |          - |         - |
