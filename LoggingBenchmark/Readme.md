# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]  : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationConst   | 20.98 μs | 1.196 μs | 6.235 μs | 0.360 μs | 9.400 μs | 36.80 μs | 47,675.8 |     584 B |
| LogInformationMessage | 21.66 μs | 1.176 μs | 6.111 μs | 0.354 μs | 7.850 μs | 42.20 μs | 46,166.8 |     328 B |
