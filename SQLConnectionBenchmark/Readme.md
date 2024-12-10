# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]      : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 161.1 μs | 1.77 μs | 23.30 μs | 0.54 μs | 113.5 μs | 243.3 μs | 6,208.8 |   6.46 KB |
| WithUsingExecution    | 285.3 μs | 5.01 μs | 66.55 μs | 1.52 μs | 178.3 μs | 531.7 μs | 3,505.2 |   9.52 KB |
