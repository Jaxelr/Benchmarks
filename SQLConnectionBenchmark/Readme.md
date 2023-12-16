# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]      : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  VeryLongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
| Method                | Mean     | Error   | StdDev    | StdErr  | Min      | Max        | Op/s    | Allocated |
|---------------------- |---------:|--------:|----------:|--------:|---------:|-----------:|--------:|----------:|
| WithoutUsingExecution | 347.3 μs | 6.27 μs |  83.45 μs | 1.90 μs | 191.6 μs |   698.2 μs | 2,879.2 |   7.02 KB |
| WithUsingExecution    | 603.3 μs | 9.62 μs | 126.84 μs | 2.92 μs | 329.1 μs | 1,092.6 μs | 1,657.5 |   9.52 KB |
