# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]  : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  LongRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |    Error |   StdDev |   StdErr |      Min |      Max |     Op/s | Allocated |
|---------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| LogInformationMessage | 32.20 μs | 2.665 μs | 13.34 μs | 0.801 μs | 15.80 μs | 77.00 μs | 31,056.9 |     720 B |
|   LogInformationConst | 34.00 μs | 2.760 μs | 13.83 μs | 0.830 μs | 15.70 μs | 79.75 μs | 29,412.9 |     352 B |
