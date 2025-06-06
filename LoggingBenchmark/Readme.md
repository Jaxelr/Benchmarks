# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]  : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min      | Max      | Op/s      | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
| LogInformationConst   | 5.979 μs | 0.2171 μs | 1.052 μs | 0.0652 μs | 5.000 μs | 11.80 μs | 167,245.6 |     584 B |
| LogInformationMessage | 6.725 μs | 0.2787 μs | 1.384 μs | 0.0838 μs | 4.100 μs | 11.40 μs | 148,709.0 |     616 B |
