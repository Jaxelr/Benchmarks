# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:


```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]      : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.161 ms | 0.0276 ms | 0.3677 ms | 0.0084 ms | 1.611 ms | 3.446 ms | 462.7 |   5.85 KB |
| WithUsingExecution    | 2.412 ms | 0.0481 ms | 0.6389 ms | 0.0146 ms | 1.601 ms | 5.542 ms | 414.5 |   6.01 KB |
