# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]    : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 236.3 ms | 16.12 ms | 22.59 ms |  4.35 ms | 206.4 ms | 301.9 ms | 4.231 | 191.89 KB |
| StaticHttpClient  | 298.2 ms | 50.89 ms | 76.16 ms | 13.91 ms | 211.9 ms | 471.3 ms | 3.354 | 147.42 KB |
| EachHttpClient    | 481.6 ms | 60.14 ms | 86.25 ms | 16.30 ms | 402.3 ms | 728.4 ms | 2.076 | 264.25 KB |
