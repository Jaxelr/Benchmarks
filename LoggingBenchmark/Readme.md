# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]  : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 6.754 μs | 0.4562 μs | 2.257 μs | 0.1371 μs | 4.700 μs | 17.50 μs | 148,071.2 |     584 B |
| LogInformationMessage | 9.406 μs | 0.7611 μs | 3.953 μs | 0.2290 μs | 5.100 μs | 22.00 μs | 106,318.5 |     616 B |
