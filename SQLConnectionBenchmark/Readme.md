# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]      : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev    | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|----------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 329.8 μs | 5.98 μs |  78.17 μs | 1.81 μs | 200.1 μs | 595.7 μs | 3,032.1 |   5.46 KB |
| WithUsingExecution    | 501.0 μs | 9.40 μs | 122.31 μs | 2.85 μs | 296.8 μs | 906.8 μs | 1,996.2 |   7.95 KB |
