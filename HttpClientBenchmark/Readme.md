# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.301
  [Host]  : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  LongRun : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |  StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 117.4 ms | 1.18 ms | 5.88 ms | 0.35 ms | 117.0 ms | 103.1 ms | 113.4 ms | 121.5 ms | 135.5 ms | 8.521 |    115 KB |
| HttpClientFactory | 117.4 ms | 1.11 ms | 5.55 ms | 0.33 ms | 117.1 ms | 105.5 ms | 113.5 ms | 120.7 ms | 136.0 ms | 8.516 |    116 KB |
|    EachHttpClient | 302.5 ms | 1.43 ms | 7.24 ms | 0.43 ms | 304.8 ms | 258.4 ms | 301.5 ms | 306.7 ms | 321.6 ms | 3.306 |    134 KB |
