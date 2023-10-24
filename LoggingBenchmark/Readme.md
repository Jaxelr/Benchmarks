# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]  : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  LongRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationConst   | 29.97 μs | 2.112 μs | 10.61 μs | 0.635 μs | 11.30 μs | 60.10 μs | 33,368.8 |     688 B |
| LogInformationMessage | 33.99 μs | 2.788 μs | 14.25 μs | 0.839 μs | 11.90 μs | 79.70 μs | 29,424.0 |     720 B |
