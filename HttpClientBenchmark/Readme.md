# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6584)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]    : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 228.0 ms | 13.06 ms | 18.74 ms | 3.54 ms | 202.9 ms | 284.5 ms | 4.385 | 128.01 KB |
| StaticHttpClient  | 243.3 ms | 12.27 ms | 17.20 ms | 3.31 ms | 216.2 ms | 279.1 ms | 4.110 | 127.45 KB |
| EachHttpClient    | 407.6 ms | 16.60 ms | 22.72 ms | 4.46 ms | 373.8 ms | 454.8 ms | 2.453 | 165.21 KB |
