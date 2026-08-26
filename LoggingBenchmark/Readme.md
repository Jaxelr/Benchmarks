# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]  : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15
Median=3.200 μs

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min       | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| LogInformationMessage | 3.263 μs | 0.1884 μs | 0.9464 μs | 0.0567 μs | 1.2000 μs |  7.800 μs | 306,492.4 |     216 B |
| LogInformationConst   | 3.621 μs | 0.3512 μs | 1.7277 μs | 0.1055 μs | 0.9000 μs | 11.600 μs | 276,203.2 |     184 B |
