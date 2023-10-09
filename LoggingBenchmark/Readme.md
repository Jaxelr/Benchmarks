# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2361/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]  : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  LongRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev   | StdErr   | Min       | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|----------:|---------:|---------:|----------:|
| LogInformationConst   | 14.11 μs | 0.389 μs | 1.985 μs | 0.117 μs |  7.100 μs | 19.80 μs | 70,855.4 |     688 B |
| LogInformationMessage | 18.66 μs | 0.641 μs | 3.256 μs | 0.193 μs | 11.300 μs | 28.80 μs | 53,591.6 |     720 B |
