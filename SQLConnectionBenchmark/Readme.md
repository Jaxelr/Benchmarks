# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.201
  [Host]  : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  LongRun : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 3.600 ms | 0.1865 ms | 0.9687 ms | 0.0561 ms | 3.441 ms | 1.805 ms | 2.859 ms | 4.232 ms | 6.117 ms | 277.8 |      6 KB |
|    WithUsingExecution | 3.751 ms | 0.1889 ms | 0.9796 ms | 0.0568 ms | 3.757 ms | 1.931 ms | 2.985 ms | 4.500 ms | 6.705 ms | 266.6 |      7 KB |
