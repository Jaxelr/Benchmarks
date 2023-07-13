# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]  : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  LongRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 284.1 ms | 4.45 ms | 22.73 ms | 1.34 ms | 212.9 ms | 348.1 ms | 3.520 | 115.25 KB |
| HttpClientFactory | 288.0 ms | 4.71 ms | 24.22 ms | 1.42 ms | 213.5 ms | 350.9 ms | 3.472 | 115.26 KB |
|    EachHttpClient | 402.0 ms | 5.07 ms | 26.22 ms | 1.53 ms | 317.5 ms | 473.7 ms | 2.487 |  134.7 KB |
