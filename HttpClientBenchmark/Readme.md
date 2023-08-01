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
|            Method |     Mean |   Error |  StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 183.0 ms | 1.62 ms | 8.11 ms | 0.49 ms | 165.9 ms | 205.8 ms | 5.464 | 116.17 KB |
| HttpClientFactory | 184.7 ms | 1.39 ms | 6.98 ms | 0.42 ms | 168.9 ms | 205.7 ms | 5.414 | 116.64 KB |
|    EachHttpClient | 311.5 ms | 1.78 ms | 9.01 ms | 0.53 ms | 291.3 ms | 342.4 ms | 3.210 | 134.46 KB |
