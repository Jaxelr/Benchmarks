# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]  : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  
Q1=7.500 μs  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 8.905 μs | 0.5132 μs | 2.530 μs | 0.1542 μs | 6.300 μs | 18.10 μs | 112,293.9 |     584 B |
| LogInformationMessage | 8.976 μs | 0.3588 μs | 1.815 μs | 0.1079 μs | 6.700 μs | 15.90 μs | 111,404.2 |     616 B |
