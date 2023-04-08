# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]  : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  LongRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |  StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 116.4 ms | 0.46 ms | 2.26 ms | 0.14 ms | 109.6 ms | 123.2 ms | 8.595 | 105.45 KB |
| HttpClientFactory | 116.8 ms | 0.54 ms | 2.72 ms | 0.16 ms | 111.8 ms | 124.3 ms | 8.563 |  106.2 KB |
|    EachHttpClient | 252.4 ms | 1.80 ms | 8.61 ms | 0.54 ms | 230.9 ms | 285.2 ms | 3.963 | 123.58 KB |
