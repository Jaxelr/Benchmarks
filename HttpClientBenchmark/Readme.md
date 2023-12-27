# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]  : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method            | Mean     | Error   | StdDev  | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  |       NA |      NA |      NA |      NA |       NA |       NA |    NA |        NA |
| HttpClientFactory |       NA |      NA |      NA |      NA |       NA |       NA |    NA |        NA |
| EachHttpClient    | 220.8 ms | 1.07 ms | 5.33 ms | 0.32 ms | 203.5 ms | 237.6 ms | 4.529 | 131.91 KB |

Benchmarks with issues:
  HttpBenchmark.StaticHttpClient: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
  HttpBenchmark.HttpClientFactory: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
