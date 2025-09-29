# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:


```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.6584)
Unknown processor
.NET SDK 9.0.305
  [Host]      : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  VeryLongRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.151 ms | 0.0277 ms | 0.3692 ms | 0.0084 ms | 1.612 ms | 3.822 ms | 464.9 |   5.85 KB |
| WithUsingExecution    | 2.550 ms | 0.0561 ms | 0.7367 ms | 0.0170 ms | 1.560 ms | 5.923 ms | 392.1 |    6.2 KB |
