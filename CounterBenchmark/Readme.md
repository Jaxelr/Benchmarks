# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]  : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.4887 ns | 0.0259 ns | 0.1343 ns | 0.0078 ns | 0.1480 ns | 0.9328 ns | 2,046,109,506.8 |          - |         - |
| IncrementInterlocked | 8.4257 ns | 0.0920 ns | 0.4764 ns | 0.0277 ns | 7.5051 ns | 9.3187 ns |   118,684,237.2 |          - |         - |
