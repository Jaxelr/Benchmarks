# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]    : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 235.8 ms | 14.73 ms | 22.05 ms | 4.03 ms | 212.4 ms | 284.6 ms | 4.241 | 177.29 KB |
| StaticHttpClient  | 248.3 ms | 22.74 ms | 34.04 ms | 6.21 ms | 211.0 ms | 354.0 ms | 4.028 | 176.29 KB |
| EachHttpClient    | 416.0 ms | 20.19 ms | 26.95 ms | 5.39 ms | 380.2 ms | 489.5 ms | 2.404 | 273.39 KB |
