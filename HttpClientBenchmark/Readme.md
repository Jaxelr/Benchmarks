# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]  : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  LongRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 147.3 ms | 1.27 ms |  6.46 ms | 0.38 ms | 147.2 ms | 133.4 ms | 142.0 ms | 151.9 ms | 166.3 ms | 6.787 |    108 KB |
|  StaticHttpClient | 148.4 ms | 1.46 ms |  7.42 ms | 0.44 ms | 148.4 ms | 131.5 ms | 143.1 ms | 153.3 ms | 168.1 ms | 6.739 |    108 KB |
|    EachHttpClient | 271.6 ms | 3.42 ms | 17.41 ms | 1.03 ms | 267.5 ms | 231.3 ms | 259.3 ms | 279.2 ms | 320.0 ms | 3.682 |    127 KB |
