# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]  : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean      | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |----------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   |  7.712 μs | 0.5045 μs | 2.529 μs | 0.1517 μs | 5.200 μs | 17.20 μs | 129,670.2 |     584 B |
| LogInformationMessage | 11.872 μs | 1.0934 μs | 5.591 μs | 0.3289 μs | 5.400 μs | 31.70 μs |  84,234.5 |     616 B |
