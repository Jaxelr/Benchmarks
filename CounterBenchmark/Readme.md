# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.3040 ns | 0.0040 ns | 0.0202 ns | 0.0012 ns | 0.2389 ns | 0.3397 ns | 3,288,975,360.4 |          - |         - |
| IncrementInterlocked | 7.8551 ns | 0.0019 ns | 0.0095 ns | 0.0006 ns | 7.8317 ns | 7.8834 ns |   127,306,634.6 |          - |         - |
