# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:


```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]      : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  VeryLongRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.392 ms | 0.0260 ms | 0.3464 ms | 0.0079 ms | 1.767 ms | 3.502 ms | 418.1 |   5.85 KB |
| WithUsingExecution    | 2.670 ms | 0.0434 ms | 0.5718 ms | 0.0132 ms | 1.759 ms | 5.212 ms | 374.5 |    6.2 KB |
