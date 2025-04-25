# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]      : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev    | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|----------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 246.0 μs | 5.20 μs |  68.06 μs | 1.58 μs | 140.6 μs | 514.5 μs | 4,065.0 |   5.46 KB |
| WithUsingExecution    | 361.1 μs | 8.89 μs | 117.14 μs | 2.70 μs | 210.3 μs | 875.4 μs | 2,769.0 |   8.23 KB |
