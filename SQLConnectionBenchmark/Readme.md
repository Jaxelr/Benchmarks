# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]      : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 180.7 μs | 1.88 μs | 24.45 μs | 0.57 μs | 120.6 μs | 283.5 μs | 5,534.2 |   7.02 KB |
| WithUsingExecution    | 304.0 μs | 4.88 μs | 64.63 μs | 1.48 μs | 204.7 μs | 543.3 μs | 3,289.3 |   9.52 KB |
