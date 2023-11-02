# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]  : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  LongRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean      | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |----------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   |  7.686 μs | 0.3067 μs | 1.560 μs | 0.0922 μs | 5.200 μs | 12.20 μs | 130,112.4 |     688 B |
| LogInformationMessage | 12.515 μs | 1.1782 μs | 5.950 μs | 0.3543 μs | 3.900 μs | 34.50 μs |  79,902.5 |     720 B |
