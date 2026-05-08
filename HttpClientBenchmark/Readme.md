# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]    : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 226.3 ms |  5.04 ms |  7.39 ms | 1.37 ms | 212.7 ms | 241.7 ms | 4.418 | 176.88 KB |
| StaticHttpClient  | 226.5 ms |  4.86 ms |  6.97 ms | 1.32 ms | 215.5 ms | 238.8 ms | 4.415 | 174.83 KB |
| EachHttpClient    | 446.6 ms | 37.19 ms | 49.64 ms | 9.93 ms | 402.8 ms | 599.3 ms | 2.239 | 269.49 KB |
