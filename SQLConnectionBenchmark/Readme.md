# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]      : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 184.0 μs | 4.96 μs | 65.63 μs | 1.50 μs | 113.0 μs | 472.8 μs | 5,433.7 |   7.87 KB |
| WithUsingExecution    | 264.0 μs | 6.33 μs | 84.14 μs | 1.92 μs | 179.5 μs | 728.9 μs | 3,787.6 |  10.36 KB |
