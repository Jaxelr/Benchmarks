# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]  : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationConst   | 15.02 μs | 0.899 μs | 4.636 μs | 0.270 μs | 6.400 μs | 28.70 μs | 66,597.2 |     584 B |
| LogInformationMessage | 17.72 μs | 1.074 μs | 5.482 μs | 0.323 μs | 9.600 μs | 36.50 μs | 56,424.1 |     616 B |
