# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]    : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 181.7 ms | 2.47 ms |  3.54 ms | 0.67 ms | 176.4 ms | 188.6 ms | 5.504 | 109.66 KB |
| StaticHttpClient  | 183.8 ms | 2.49 ms |  3.65 ms | 0.68 ms | 178.2 ms | 191.4 ms | 5.441 | 108.88 KB |
| EachHttpClient    | 366.2 ms | 9.34 ms | 13.69 ms | 2.54 ms | 347.5 ms | 398.2 ms | 2.731 | 146.41 KB |
