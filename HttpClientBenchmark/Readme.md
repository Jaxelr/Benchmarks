# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]    : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 199.7 ms | 2.40 ms |  3.59 ms | 0.66 ms | 191.6 ms | 206.5 ms | 5.007 | 109.58 KB |
| HttpClientFactory | 199.8 ms | 2.41 ms |  3.46 ms | 0.65 ms | 195.0 ms | 208.8 ms | 5.004 | 109.89 KB |
| EachHttpClient    | 391.5 ms | 7.31 ms | 10.71 ms | 1.99 ms | 376.0 ms | 414.8 ms | 2.554 | 148.34 KB |
