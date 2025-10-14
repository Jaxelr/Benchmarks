# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6725)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  
Q1=2.800 μs  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|----------:|----------:|----------:|
| LogInformationMessage | 3.338 μs | 0.1388 μs | 0.6629 μs | 0.0417 μs | 2.300 μs |  6.000 μs | 299,621.0 |     216 B |
| LogInformationConst   | 4.004 μs | 0.4390 μs | 2.1724 μs | 0.1320 μs | 2.400 μs | 13.300 μs | 249,746.6 |     184 B |
