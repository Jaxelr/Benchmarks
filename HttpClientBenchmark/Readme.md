# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]    : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 218.3 ms |  4.25 ms |  6.09 ms | 1.15 ms | 206.7 ms | 232.7 ms | 4.581 | 130.74 KB |
| HttpClientFactory | 235.8 ms | 36.20 ms | 53.06 ms | 9.85 ms | 206.7 ms | 423.9 ms | 4.241 | 130.94 KB |
| EachHttpClient    | 436.7 ms | 27.55 ms | 41.24 ms | 7.53 ms | 390.3 ms | 554.6 ms | 2.290 | 168.97 KB |
