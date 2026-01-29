# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]  : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100
LaunchCount=3  UnrollFactor=1  WarmupCount=15
Median=3.300 μs

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationMessage | 3.316 μs | 0.1211 μs | 0.6047 μs | 0.0364 μs | 1.300 μs | 5.700 μs | 301,540.5 |     216 B |
| LogInformationConst   | 3.325 μs | 0.1249 μs | 0.6190 μs | 0.0375 μs | 1.900 μs | 5.700 μs | 300,785.1 |     184 B |
