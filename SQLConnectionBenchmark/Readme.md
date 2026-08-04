# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]      : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.732 ms | 0.0414 ms | 0.5480 ms | 0.0126 ms | 1.689 ms | 4.726 ms | 366.1 |  14.05 KB |
| WithUsingExecution    | 2.983 ms | 0.0587 ms | 0.7727 ms | 0.0178 ms | 1.689 ms | 5.640 ms | 335.3 |  14.48 KB |
