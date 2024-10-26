# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]    : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 201.1 ms |  3.67 ms |  4.90 ms |  0.98 ms | 192.4 ms | 214.3 ms | 4.973 |  115.1 KB |
| StaticHttpClient  | 202.1 ms |  7.13 ms | 10.45 ms |  1.94 ms | 191.5 ms | 232.9 ms | 4.948 |  113.4 KB |
| EachHttpClient    | 414.4 ms | 43.21 ms | 63.33 ms | 11.76 ms | 372.8 ms | 604.1 ms | 2.413 | 155.83 KB |
