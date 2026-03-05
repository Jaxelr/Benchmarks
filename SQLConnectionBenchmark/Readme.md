# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7922/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]      : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500
LaunchCount=4  UnrollFactor=1  WarmupCount=30

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|----------:|------:|----------:|
| WithoutUsingExecution | 3.034 ms | 0.0698 ms | 0.9265 ms | 0.0212 ms | 1.619 ms |  6.340 ms | 329.6 |   5.85 KB |
| WithUsingExecution    | 6.325 ms | 0.4673 ms | 6.1119 ms | 0.1418 ms | 1.777 ms | 40.150 ms | 158.1 |   5.88 KB |
