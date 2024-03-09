# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]      : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean       | Error    | StdDev   | StdErr  | Min      | Max        | Op/s    | Allocated |
|---------------------- |-----------:|---------:|---------:|--------:|---------:|-----------:|--------:|----------:|
| WithoutUsingExecution |   825.2 μs | 13.81 μs | 184.8 μs | 4.19 μs | 486.6 μs | 1,525.8 μs | 1,211.8 |   5.71 KB |
| WithUsingExecution    | 1,289.6 μs | 19.02 μs | 252.4 μs | 5.77 μs | 663.2 μs | 2,266.1 μs |   775.4 |    8.2 KB |
