# Round Robin counter benchmarks

This is a benchmark counter for the round robin counts we use to select instance of components

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]  : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method               | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Exceptions | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|-----------:|----------:|
| Increment            | 0.2891 ns | 0.0049 ns | 0.0246 ns | 0.0015 ns | 0.2518 ns | 0.3120 ns | 3,459,082,763.0 |          - |         - |
| IncrementInterlocked | 7.8673 ns | 0.0068 ns | 0.0337 ns | 0.0020 ns | 7.8100 ns | 7.9668 ns |   127,107,693.9 |          - |         - |
