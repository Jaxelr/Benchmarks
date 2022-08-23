# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.303
  [Host]  : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  LongRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 170.6 ms | 1.84 ms |  9.43 ms | 0.55 ms | 168.8 ms | 151.7 ms | 163.6 ms | 175.9 ms | 208.4 ms | 5.863 |    109 KB |
|  StaticHttpClient | 172.6 ms | 1.96 ms | 10.06 ms | 0.59 ms | 171.7 ms | 151.3 ms | 165.0 ms | 179.1 ms | 204.5 ms | 5.794 |    108 KB |
|    EachHttpClient | 297.5 ms | 3.03 ms | 15.36 ms | 0.91 ms | 294.6 ms | 271.3 ms | 287.4 ms | 304.7 ms | 361.5 ms | 3.361 |    127 KB |
