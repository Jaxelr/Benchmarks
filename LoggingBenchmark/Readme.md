# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]  : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  LongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationConst   | 11.03 μs | 0.573 μs | 2.927 μs | 0.172 μs | 5.600 μs | 20.10 μs | 90,637.3 |     584 B |
| LogInformationMessage | 14.39 μs | 0.987 μs | 5.074 μs | 0.297 μs | 6.800 μs | 31.00 μs | 69,479.1 |     616 B |
