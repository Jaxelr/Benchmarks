# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]  : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  LongRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |  StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 189.2 ms | 1.31 ms | 6.55 ms | 0.39 ms | 177.7 ms | 214.3 ms | 5.286 | 111.53 KB |
|  StaticHttpClient | 189.4 ms | 1.75 ms | 8.82 ms | 0.53 ms | 176.6 ms | 225.2 ms | 5.279 | 110.95 KB |
|    EachHttpClient | 320.7 ms | 1.78 ms | 9.08 ms | 0.54 ms | 304.5 ms | 355.6 ms | 3.119 | 130.15 KB |
