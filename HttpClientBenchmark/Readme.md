# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]    : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 186.5 ms | 2.98 ms |  4.18 ms | 0.80 ms | 180.0 ms | 196.3 ms | 5.363 |  111.6 KB |
| HttpClientFactory | 190.3 ms | 5.24 ms |  7.84 ms | 1.43 ms | 179.9 ms | 211.1 ms | 5.256 | 104.33 KB |
| EachHttpClient    | 362.0 ms | 7.39 ms | 10.83 ms | 2.01 ms | 346.4 ms | 392.2 ms | 2.762 | 149.26 KB |
