# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]      : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithUsingExecution    | 2.497 ms | 0.0405 ms | 0.5391 ms | 0.0123 ms | 1.550 ms | 4.383 ms | 400.5 |  14.48 KB |
| WithoutUsingExecution | 2.931 ms | 0.0587 ms | 0.7819 ms | 0.0178 ms | 1.670 ms | 5.517 ms | 341.2 |  14.05 KB |
