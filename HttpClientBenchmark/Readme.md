# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]  : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  LongRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 172.9 ms | 3.23 ms | 16.18 ms | 0.97 ms | 168.9 ms | 147.9 ms | 161.6 ms | 179.3 ms | 231.7 ms | 5.785 |    108 KB |
| HttpClientFactory | 176.7 ms | 3.31 ms | 16.51 ms | 0.99 ms | 171.9 ms | 154.6 ms | 165.4 ms | 182.9 ms | 235.8 ms | 5.660 |    109 KB |
|    EachHttpClient | 293.5 ms | 2.19 ms | 11.27 ms | 0.66 ms | 292.8 ms | 266.7 ms | 284.9 ms | 300.4 ms | 325.0 ms | 3.407 |    126 KB |
