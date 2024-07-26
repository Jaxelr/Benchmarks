# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]      : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean       | Error     | StdDev     | StdErr   | Min      | Max         | Op/s    | Allocated |
|---------------------- |-----------:|----------:|-----------:|---------:|---------:|------------:|--------:|----------:|
| WithoutUsingExecution |   998.7 μs |  17.73 μs |   234.5 μs |  5.38 μs | 510.2 μs |  1,855.5 μs | 1,001.3 |   5.52 KB |
| WithUsingExecution    | 2,031.4 μs | 116.26 μs | 1,507.0 μs | 35.28 μs | 755.1 μs | 10,381.4 μs |   492.3 |    8.2 KB |
