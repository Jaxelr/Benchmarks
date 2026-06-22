# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]  : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15
Q1=2.800 μs  Q3=3.400 μs

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationMessage | 3.087 μs | 0.1176 μs | 0.5861 μs | 0.0353 μs | 2.000 μs | 6.100 μs | 323,948.6 |     216 B |
| LogInformationConst   | 3.120 μs | 0.1049 μs | 0.5247 μs | 0.0315 μs | 1.400 μs | 4.900 μs | 320,472.0 |     184 B |
