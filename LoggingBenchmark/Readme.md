# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]  : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|----------:|----------:|----------:|
| LogInformationConst   | 3.554 μs | 0.1734 μs | 0.8613 μs | 0.0521 μs | 1.800 μs |  6.800 μs | 281,356.3 |     184 B |
| LogInformationMessage | 4.872 μs | 1.0505 μs | 5.2855 μs | 0.3159 μs | 1.600 μs | 26.700 μs | 205,256.0 |     216 B |
