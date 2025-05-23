# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]    : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 185.7 ms |  2.76 ms |  3.95 ms | 0.75 ms | 178.0 ms | 194.4 ms | 5.384 | 108.22 KB |
| HttpClientFactory | 228.8 ms | 34.09 ms | 49.97 ms | 9.28 ms | 182.4 ms | 311.6 ms | 4.370 | 102.77 KB |
| EachHttpClient    | 354.7 ms |  6.32 ms |  9.06 ms | 1.71 ms | 339.6 ms | 375.8 ms | 2.819 | 146.69 KB |
