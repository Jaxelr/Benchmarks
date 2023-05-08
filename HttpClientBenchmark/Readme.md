# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]  : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  LongRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 121.6 ms | 0.61 ms |  3.00 ms | 0.18 ms | 115.3 ms | 132.0 ms | 8.222 | 109.33 KB |
| HttpClientFactory | 143.5 ms | 0.74 ms |  3.73 ms | 0.22 ms | 135.8 ms | 154.7 ms | 6.967 | 110.08 KB |
|    EachHttpClient | 275.8 ms | 2.82 ms | 14.25 ms | 0.85 ms | 245.2 ms | 318.2 ms | 3.626 | 127.82 KB |
