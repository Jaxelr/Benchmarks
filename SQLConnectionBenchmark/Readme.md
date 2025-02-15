# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]      : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 303.2 μs | 3.94 μs | 52.25 μs | 1.19 μs | 198.2 μs | 488.8 μs | 3,298.4 |   5.46 KB |
| WithUsingExecution    | 493.2 μs | 6.51 μs | 86.44 μs | 1.97 μs | 324.6 μs | 811.0 μs | 2,027.6 |   8.23 KB |
