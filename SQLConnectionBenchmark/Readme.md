# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]  : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  LongRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.342 ms | 0.0821 ms | 0.4255 ms | 0.0247 ms | 1.411 ms | 3.221 ms | 427.0 |   6.53 KB |
|    WithUsingExecution | 2.657 ms | 0.1111 ms | 0.5742 ms | 0.0334 ms | 1.557 ms | 4.024 ms | 376.4 |   7.14 KB |
