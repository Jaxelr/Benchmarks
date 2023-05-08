# Logging benchmark

I'm measuring the difference between using different types of logging formats.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]  : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  LongRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  
Median=8.800 μs  

```
|                Method |     Mean |     Error |   StdDev |    StdErr |      Min |      Max |      Op/s | Allocated |
|---------------------- |---------:|----------:|---------:|----------:|---------:|---------:|----------:|----------:|
|   LogInformationConst | 9.276 μs | 0.4904 μs | 2.525 μs | 0.1475 μs | 4.500 μs | 18.80 μs | 107,803.8 |     568 B |
| LogInformationMessage | 9.671 μs | 0.5515 μs | 2.845 μs | 0.1659 μs | 5.500 μs | 21.30 μs | 103,397.3 |     600 B |
