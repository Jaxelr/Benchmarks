# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]  : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min      | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|----------:|----------:|----------:|
| LogInformationMessage | 3.515 μs | 0.2411 μs | 1.180 μs | 0.0725 μs | 1.800 μs |  9.800 μs | 284,517.9 |     216 B |
| LogInformationConst   | 4.426 μs | 0.3774 μs | 1.861 μs | 0.1134 μs | 2.200 μs | 12.600 μs | 225,917.5 |     184 B |
