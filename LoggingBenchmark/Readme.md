# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]  : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min       | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|----------:|---------:|----------:|----------:|
| LogInformationMessage | 3.354 μs | 0.2941 μs | 1.4876 μs | 0.0884 μs | 0.7000 μs | 7.900 μs | 298,145.8 |     216 B |
| LogInformationConst   | 3.489 μs | 0.1677 μs | 0.7947 μs | 0.0504 μs | 0.7000 μs | 6.100 μs | 286,602.2 |     184 B |
