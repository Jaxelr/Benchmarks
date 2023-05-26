# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1778)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.302
  [Host]  : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  LongRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |       Min |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|----------:|---------:|------:|----------:|
| WithoutUsingExecution | 1.032 ms | 0.0481 ms | 0.2487 ms | 0.0145 ms | 0.7149 ms | 1.748 ms | 969.4 |   7.73 KB |
|    WithUsingExecution | 1.335 ms | 0.0589 ms | 0.3049 ms | 0.0177 ms | 0.7510 ms | 2.196 ms | 748.9 |   7.21 KB |
