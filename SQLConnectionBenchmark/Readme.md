# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]      : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s    | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 191.3 μs | 4.37 μs | 56.71 μs | 1.33 μs | 114.9 μs | 455.2 μs | 5,226.6 |   7.02 KB |
| WithUsingExecution    | 302.6 μs | 6.49 μs | 85.54 μs | 1.97 μs | 173.1 μs | 615.4 μs | 3,304.7 |   9.52 KB |
