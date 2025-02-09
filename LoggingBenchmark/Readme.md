# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]  : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean      | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |----------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   |  8.453 μs | 0.6877 μs | 3.429 μs | 0.2068 μs | 5.300 μs | 23.40 μs | 118,299.9 |     584 B |
| LogInformationMessage | 11.113 μs | 0.7546 μs | 3.783 μs | 0.2269 μs | 6.850 μs | 24.55 μs |  89,980.7 |     616 B |
