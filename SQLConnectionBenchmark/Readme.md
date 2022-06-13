# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]  : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  LongRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |    Op/s | Allocated |
|---------------------- |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|--------:|----------:|
| WithoutUsingExecution | 174.4 μs | 5.70 μs | 28.89 μs | 1.71 μs | 163.6 μs | 135.3 μs | 153.6 μs | 189.6 μs | 273.2 μs | 5,735.2 |      8 KB |
|    WithUsingExecution | 278.6 μs | 8.49 μs | 43.04 μs | 2.55 μs | 268.2 μs | 209.7 μs | 248.9 μs | 299.4 μs | 448.5 μs | 3,590.0 |     11 KB |
