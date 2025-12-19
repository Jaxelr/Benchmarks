# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 226.7 ms | 11.98 ms | 16.80 ms | 3.23 ms | 209.5 ms | 277.3 ms | 4.412 | 158.54 KB |
| StaticHttpClient  | 232.2 ms |  7.98 ms | 10.93 ms | 2.14 ms | 214.0 ms | 251.9 ms | 4.307 |  158.1 KB |
| EachHttpClient    | 423.1 ms | 19.48 ms | 27.94 ms | 5.28 ms | 392.4 ms | 497.4 ms | 2.364 | 271.28 KB |
