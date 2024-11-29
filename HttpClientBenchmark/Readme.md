# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]    : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 198.9 ms |  2.80 ms |  3.93 ms | 0.76 ms | 193.8 ms | 207.6 ms | 5.028 |  116.1 KB |
| StaticHttpClient  | 205.0 ms |  5.50 ms |  8.23 ms | 1.50 ms | 194.7 ms | 223.5 ms | 4.879 | 115.26 KB |
| EachHttpClient    | 399.8 ms | 11.71 ms | 16.79 ms | 3.17 ms | 377.6 ms | 451.8 ms | 2.501 | 154.65 KB |
