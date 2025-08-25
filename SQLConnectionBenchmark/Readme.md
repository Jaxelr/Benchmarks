# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:


```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]      : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  VeryLongRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.358 ms | 0.0369 ms | 0.4854 ms | 0.0112 ms | 1.689 ms | 4.363 ms | 424.1 |   5.85 KB |
| WithUsingExecution    | 2.480 ms | 0.0382 ms | 0.5075 ms | 0.0116 ms | 1.645 ms | 4.415 ms | 403.3 |    6.2 KB |
