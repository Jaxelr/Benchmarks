# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]  : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  LongRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |  StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 139.1 ms | 1.25 ms | 6.37 ms | 0.38 ms | 124.7 ms | 158.3 ms | 7.187 | 111.21 KB |
|  StaticHttpClient | 145.1 ms | 1.48 ms | 7.50 ms | 0.44 ms | 126.9 ms | 174.9 ms | 6.894 |  109.1 KB |
|    EachHttpClient | 267.7 ms | 1.90 ms | 9.35 ms | 0.57 ms | 245.2 ms | 301.8 ms | 3.736 | 129.14 KB |
