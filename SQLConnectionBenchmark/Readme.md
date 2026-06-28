# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]      : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.098 ms | 0.0264 ms | 0.3473 ms | 0.0080 ms | 1.484 ms | 3.423 ms | 476.7 |  14.05 KB |
| WithUsingExecution    | 2.421 ms | 0.0446 ms | 0.5863 ms | 0.0135 ms | 1.562 ms | 4.675 ms | 413.0 |  14.48 KB |
