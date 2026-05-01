# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]      : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.640 ms | 0.0280 ms | 0.3715 ms | 0.0085 ms | 1.867 ms | 3.842 ms | 378.8 |  14.05 KB |
| WithUsingExecution    | 2.776 ms | 0.0576 ms | 0.7655 ms | 0.0175 ms | 1.691 ms | 6.855 ms | 360.2 |  14.48 KB |
