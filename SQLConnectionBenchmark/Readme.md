# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]  : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  LongRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.367 ms | 0.0309 ms | 0.1574 ms | 0.0093 ms | 2.027 ms | 2.791 ms | 422.4 |   6.41 KB |
|    WithUsingExecution | 2.489 ms | 0.0322 ms | 0.1647 ms | 0.0097 ms | 2.090 ms | 3.010 ms | 401.8 |   7.21 KB |
