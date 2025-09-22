# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min       | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| LogInformationConst   | 3.344 μs | 0.1727 μs | 0.8561 μs | 0.0519 μs | 1.8000 μs |  6.100 μs | 298,999.7 |     184 B |
| LogInformationMessage | 4.984 μs | 0.6701 μs | 3.2782 μs | 0.2014 μs | 0.9500 μs | 19.300 μs | 200,636.0 |     216 B |
