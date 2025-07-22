# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]  : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 3.155 μs | 0.1085 μs | 0.5338 μs | 0.0326 μs | 2.050 μs | 5.000 μs | 316,916.0 |     184 B |
| LogInformationMessage | 3.652 μs | 0.2060 μs | 1.0096 μs | 0.0619 μs | 2.200 μs | 9.100 μs | 273,803.4 |     216 B |
