# Sql Connection benchmark

I needed to measure how much impact adding multiple usings add, instead of recycling 1 connection:

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]      : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  VeryLongRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=VeryLongRun  InvocationCount=1  IterationCount=500  
LaunchCount=4  UnrollFactor=1  WarmupCount=30  

```
|                Method |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |  Op/s | Allocated |
|---------------------- |---------:|----------:|----------:|----------:|---------:|---------:|------:|----------:|
| WithoutUsingExecution | 2.079 ms | 0.0437 ms | 0.5895 ms | 0.0133 ms | 1.066 ms | 4.028 ms | 481.1 |   6.25 KB |
|    WithUsingExecution | 2.324 ms | 0.0377 ms | 0.5094 ms | 0.0114 ms | 1.216 ms | 3.769 ms | 430.2 |   6.86 KB |
