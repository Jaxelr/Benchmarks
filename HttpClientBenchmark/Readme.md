# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]    : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 197.2 ms |  4.82 ms |  6.91 ms | 1.31 ms | 183.3 ms | 208.3 ms | 5.071 | 108.64 KB |
| HttpClientFactory | 200.3 ms |  4.35 ms |  6.51 ms | 1.19 ms | 190.9 ms | 218.0 ms | 4.993 | 103.11 KB |
| EachHttpClient    | 382.2 ms | 13.97 ms | 20.48 ms | 3.80 ms | 352.7 ms | 433.2 ms | 2.617 | 146.67 KB |
