# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:


```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]      : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  VeryLongRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.125 ms | 0.0272 ms | 0.3576 ms | 0.0082 ms | 1.513 ms | 3.566 ms | 470.6 |   5.85 KB |
| WithUsingExecution    | 2.467 ms | 0.0427 ms | 0.5590 ms | 0.0130 ms | 1.569 ms | 4.500 ms | 405.4 |    6.2 KB |
