# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]  : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  LongRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 124.6 ms | 1.44 ms |  7.38 ms | 0.43 ms | 122.3 ms | 113.1 ms | 118.9 ms | 130.0 ms | 148.2 ms | 8.025 | 106.65 KB |
| HttpClientFactory | 143.3 ms | 5.32 ms | 26.89 ms | 1.60 ms | 129.8 ms | 113.6 ms | 121.1 ms | 174.6 ms | 202.8 ms | 6.977 | 107.68 KB |
|    EachHttpClient | 254.5 ms | 1.49 ms |  7.49 ms | 0.45 ms | 253.5 ms | 230.9 ms | 249.1 ms | 259.6 ms | 275.8 ms | 3.929 | 125.42 KB |
