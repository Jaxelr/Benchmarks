# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]      : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.497 ms | 0.0294 ms | 0.3907 ms | 0.0089 ms | 1.756 ms | 3.891 ms | 400.4 |  14.05 KB |
| WithUsingExecution    | 2.865 ms | 0.0519 ms | 0.6876 ms | 0.0157 ms | 1.730 ms | 5.345 ms | 349.1 |  14.48 KB |
