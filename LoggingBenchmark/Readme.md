# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]  : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error    | StdDev    | StdErr   | Min      | Max      | Op/s     | Allocated |
|---------------------- |---------:|---------:|----------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationConst   | 21.31 μs | 1.937 μs |  9.638 μs | 0.582 μs | 11.70 μs | 59.50 μs | 46,927.5 |     584 B |
| LogInformationMessage | 23.87 μs | 2.355 μs | 12.000 μs | 0.708 μs | 12.00 μs | 68.10 μs | 41,900.3 |     616 B |
