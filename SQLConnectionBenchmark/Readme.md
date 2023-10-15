# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]      : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  VeryLongRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s  | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|----------:|------:|----------:|
| WithoutUsingExecution | 6.176 ms | 0.0382 ms | 0.5031 ms | 0.0116 ms | 4.290 ms |  7.931 ms | 161.9 |   6.25 KB |
| WithUsingExecution    | 7.211 ms | 0.0587 ms | 0.7623 ms | 0.0178 ms | 5.310 ms | 10.537 ms | 138.7 |   6.86 KB |
