# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]  : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 3.296 μs | 0.1801 μs | 0.8861 μs | 0.0541 μs | 1.700 μs | 7.300 μs | 303,424.9 |     184 B |
| LogInformationMessage | 3.463 μs | 0.1047 μs | 0.5153 μs | 0.0315 μs | 1.600 μs | 5.000 μs | 288,762.0 |     216 B |
