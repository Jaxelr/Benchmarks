# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]  : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  LongRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |     Mean |     Error |   StdDev |    StdErr |      Min |      Max |      Op/s | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
|   LogInformationConst | 7.827 μs | 0.3370 μs | 1.680 μs | 0.1013 μs | 5.200 μs | 14.60 μs | 127,770.3 |     688 B |
| LogInformationMessage | 8.788 μs | 0.4352 μs | 2.170 μs | 0.1308 μs | 5.000 μs | 15.40 μs | 113,791.5 |     720 B |
