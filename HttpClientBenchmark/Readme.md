# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]  : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  LongRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 136.1 ms | 0.82 ms |  4.12 ms | 0.25 ms | 125.6 ms | 148.5 ms | 7.346 | 110.22 KB |
| HttpClientFactory | 143.1 ms | 2.13 ms | 10.61 ms | 0.64 ms | 131.5 ms | 195.0 ms | 6.990 | 112.03 KB |
| EachHttpClient    | 282.6 ms | 3.34 ms | 16.53 ms | 1.00 ms | 257.0 ms | 346.1 ms | 3.539 | 129.56 KB |
