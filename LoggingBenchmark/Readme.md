# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]  : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationMessage | 2.899 μs | 0.1537 μs | 0.7762 μs | 0.0462 μs | 1.100 μs | 4.800 μs | 344,996.3 |     216 B |
| LogInformationConst   | 3.806 μs | 0.2191 μs | 1.0634 μs | 0.0658 μs | 1.300 μs | 7.800 μs | 262,734.0 |     184 B |
