# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]  : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  LongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  |       NA |      NA |       NA |      NA |       NA |       NA |    NA |        NA |
| HttpClientFactory |       NA |      NA |       NA |      NA |       NA |       NA |    NA |        NA |
| EachHttpClient    | 281.8 ms | 3.80 ms | 18.90 ms | 1.14 ms | 256.9 ms | 376.0 ms | 3.549 | 131.46 KB |

Benchmarks with issues:
  HttpBenchmark.StaticHttpClient: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
  HttpBenchmark.HttpClientFactory: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
