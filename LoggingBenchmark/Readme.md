# Logging benchmark

I'm measuring the difference between using different types of logging formats.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2361/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]  : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  LongRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
|                Method |      Mean |     Error |   StdDev |    StdErr |      Min |      Max |      Op/s | Allocated |
|---------------------- |----------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
|   LogInformationConst |  9.730 μs | 0.5777 μs | 2.959 μs | 0.1738 μs | 4.100 μs | 18.90 μs | 102,778.6 |     688 B |
| LogInformationMessage | 10.066 μs | 0.4445 μs | 2.236 μs | 0.1336 μs | 5.700 μs | 15.90 μs |  99,343.6 |     720 B |
