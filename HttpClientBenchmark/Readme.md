# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]  : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  LongRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  |       NA |      NA |       NA |      NA |       NA |       NA |    NA |        NA |
| HttpClientFactory | 241.8 ms | 6.28 ms | 18.21 ms | 1.85 ms | 206.5 ms | 291.3 ms | 4.135 |        NA |
| EachHttpClient    | 348.7 ms | 6.88 ms | 34.40 ms | 2.07 ms | 301.5 ms | 456.2 ms | 2.868 | 133.48 KB |

Benchmarks with issues:
  HttpBenchmark.StaticHttpClient: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
