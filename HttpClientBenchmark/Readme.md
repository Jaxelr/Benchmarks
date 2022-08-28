# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]  : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  LongRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 215.4 ms | 3.16 ms | 15.64 ms | 0.95 ms | 211.4 ms | 188.0 ms | 203.3 ms | 226.5 ms | 274.1 ms | 4.643 |    109 KB |
|  StaticHttpClient | 227.4 ms | 3.17 ms | 15.94 ms | 0.95 ms | 227.0 ms | 193.1 ms | 214.4 ms | 238.7 ms | 271.7 ms | 4.397 |    108 KB |
|    EachHttpClient | 358.8 ms | 6.99 ms | 35.68 ms | 2.10 ms | 346.6 ms | 315.0 ms | 332.7 ms | 382.2 ms | 508.6 ms | 2.787 |    127 KB |
