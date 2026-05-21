# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]    : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev    | StdErr   | Min      | Max        | Op/s  | Allocated |
|------------------ |---------:|---------:|----------:|---------:|---------:|-----------:|------:|----------:|
| HttpClientFactory | 310.6 ms | 12.53 ms |  17.57 ms |  3.38 ms | 284.7 ms |   351.4 ms | 3.220 | 135.05 KB |
| StaticHttpClient  | 338.8 ms | 14.72 ms |  20.15 ms |  3.95 ms | 309.3 ms |   396.6 ms | 2.952 | 134.05 KB |
| EachHttpClient    | 661.8 ms | 90.27 ms | 120.51 ms | 24.10 ms | 562.4 ms | 1,048.6 ms | 1.511 | 170.86 KB |
