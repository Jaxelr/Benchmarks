# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]    : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev  | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 181.2 ms | 1.37 ms | 1.92 ms | 0.37 ms | 177.9 ms | 185.0 ms | 5.518 | 110.55 KB |
| HttpClientFactory | 182.7 ms | 3.65 ms | 5.12 ms | 0.98 ms | 177.1 ms | 196.3 ms | 5.473 | 110.91 KB |
| EachHttpClient    | 348.9 ms | 4.25 ms | 6.23 ms | 1.16 ms | 336.0 ms | 361.4 ms | 2.866 | 149.26 KB |
