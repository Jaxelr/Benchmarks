# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs 

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]    : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error   | StdDev  | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|--------:|--------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 200.5 ms | 1.76 ms | 2.52 ms | 0.48 ms | 197.0 ms | 207.8 ms | 4.988 | 116.11 KB |
| StaticHttpClient  | 204.4 ms | 2.75 ms | 3.86 ms | 0.74 ms | 197.9 ms | 214.3 ms | 4.892 | 115.38 KB |
| EachHttpClient    | 432.5 ms | 4.85 ms | 7.26 ms | 1.33 ms | 421.3 ms | 450.5 ms | 2.312 | 156.05 KB |
