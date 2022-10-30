# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]  : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  LongRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
|            Method |     Mean |   Error |   StdDev |  StdErr |      Min |      Max |  Op/s | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
|  StaticHttpClient | 194.2 ms | 2.85 ms | 14.64 ms | 0.86 ms | 130.0 ms | 229.3 ms | 5.149 | 106.65 KB |
| HttpClientFactory | 251.7 ms | 3.47 ms | 17.76 ms | 1.04 ms | 211.3 ms | 310.2 ms | 3.973 | 107.65 KB |
|    EachHttpClient | 380.1 ms | 5.40 ms | 27.81 ms | 1.62 ms | 323.0 ms | 466.7 ms | 2.631 | 126.57 KB |
