# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]    : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 231.8 ms | 3.10 ms |  4.34 ms | 0.84 ms | 225.3 ms | 241.2 ms | 4.315 | 114.02 KB |
| StaticHttpClient  | 267.9 ms | 7.89 ms | 11.57 ms | 2.15 ms | 254.9 ms | 302.5 ms | 3.732 | 113.95 KB |
| EachHttpClient    | 480.4 ms | 9.55 ms | 14.00 ms | 2.60 ms | 448.1 ms | 506.3 ms | 2.081 | 154.72 KB |
