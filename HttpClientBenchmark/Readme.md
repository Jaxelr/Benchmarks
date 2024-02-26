# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]  : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method            | Mean     | Error   | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 340.9 ms | 5.84 ms | 29.35 ms | 1.76 ms | 303.4 ms | 429.1 ms | 2.933 | 112.53 KB |
| StaticHttpClient  | 360.0 ms | 7.96 ms | 40.25 ms | 2.39 ms | 301.8 ms | 488.5 ms | 2.778 | 111.79 KB |
| EachHttpClient    | 443.2 ms | 3.99 ms | 20.41 ms | 1.20 ms | 398.5 ms | 499.6 ms | 2.256 | 130.41 KB |
