# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]  : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 3.013 μs | 0.1408 μs | 0.7138 μs | 0.0424 μs | 1.800 μs | 5.300 μs | 331,892.0 |     184 B |
| LogInformationMessage | 3.583 μs | 0.1687 μs | 0.8286 μs | 0.0507 μs | 2.200 μs | 6.200 μs | 279,084.4 |     216 B |
