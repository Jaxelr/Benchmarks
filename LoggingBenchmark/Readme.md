# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min      | Max       | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|----------:|----------:|----------:|
| LogInformationMessage | 3.392 μs | 0.2092 μs | 1.053 μs | 0.0629 μs | 1.800 μs |  8.500 μs | 294,829.9 |     216 B |
| LogInformationConst   | 3.939 μs | 0.2521 μs | 1.214 μs | 0.0757 μs | 1.100 μs | 10.100 μs | 253,902.4 |     184 B |
