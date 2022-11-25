# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]  : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  LongRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |  StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 116.8 ms | 0.65 ms | 3.28 ms | 0.19 ms | 108.9 ms | 127.3 ms | 8.564 | 105.97 KB |
|  StaticHttpClient | 119.5 ms | 0.65 ms | 3.31 ms | 0.20 ms | 112.2 ms | 128.3 ms | 8.368 | 105.27 KB |
|    EachHttpClient | 253.4 ms | 1.89 ms | 9.54 ms | 0.57 ms | 237.3 ms | 294.5 ms | 3.947 | 123.18 KB |
