# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]    : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 265.6 ms | 11.04 ms | 16.52 ms |  3.02 ms | 241.3 ms | 299.8 ms | 3.765 | 125.68 KB |
| HttpClientFactory | 284.9 ms | 46.17 ms | 66.22 ms | 12.51 ms | 234.3 ms | 458.5 ms | 3.510 | 126.72 KB |
| EachHttpClient    | 480.9 ms | 14.87 ms | 20.85 ms |  4.01 ms | 443.1 ms | 531.0 ms | 2.080 | 164.05 KB |
