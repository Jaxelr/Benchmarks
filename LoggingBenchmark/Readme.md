# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min       | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|----------:|----------:|----------:|----------:|
| LogInformationMessage | 3.064 μs | 0.2396 μs | 1.201 μs | 0.0720 μs | 0.6500 μs |  6.750 μs | 326,367.7 |     216 B |
| LogInformationConst   | 3.108 μs | 0.2641 μs | 1.319 μs | 0.0794 μs | 1.1000 μs | 10.700 μs | 321,715.8 |     184 B |
