# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.302
  [Host]    : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 199.1 ms |  2.77 ms |  3.80 ms | 0.74 ms | 193.3 ms | 208.4 ms | 5.023 | 118.78 KB |
| StaticHttpClient  | 203.5 ms | 11.35 ms | 15.53 ms | 3.05 ms | 192.0 ms | 265.0 ms | 4.913 |  119.5 KB |
| EachHttpClient    | 386.3 ms |  7.13 ms | 10.44 ms | 1.94 ms | 374.3 ms | 413.0 ms | 2.589 | 157.06 KB |
