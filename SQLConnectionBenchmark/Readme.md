# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]      : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error     | StdDev   | StdErr    | Min       | Max       | Op/s  | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|----------:|----------:|------:|----------:|
| WithoutUsingExecution | 1.092 ms | 0.0918 ms | 1.173 ms | 0.0278 ms | 0.2019 ms |  6.908 ms | 916.0 |   5.18 KB |
| WithUsingExecution    | 3.152 ms | 0.2652 ms | 3.443 ms | 0.0805 ms | 0.3157 ms | 22.058 ms | 317.3 |   7.86 KB |
