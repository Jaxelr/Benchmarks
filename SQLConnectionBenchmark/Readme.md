# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]  : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  LongRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 4.385 ms | 0.1433 ms | 0.7262 ms | 0.0431 ms | 2.819 ms | 7.046 ms | 228.0 |   6.35 KB |
|    WithUsingExecution | 4.962 ms | 0.1525 ms | 0.7812 ms | 0.0459 ms | 2.525 ms | 7.476 ms | 201.5 |   6.99 KB |
