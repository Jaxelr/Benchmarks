# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]  : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.3110 ns | 0.0355 ns | 0.1785 ns | 0.0107 ns | 0.1216 ns | 0.7064 ns | 3,215,664,799.2 |          - |         - |
| IncrementInterlocked | 7.2281 ns | 0.1291 ns | 0.6636 ns | 0.0388 ns | 6.4388 ns | 8.9508 ns |   138,348,979.2 |          - |         - |
