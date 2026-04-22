# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.202
  [Host]    : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 229.6 ms |  6.45 ms |  9.45 ms | 1.75 ms | 215.2 ms | 252.2 ms | 4.355 |  168.6 KB |
| HttpClientFactory | 238.2 ms | 14.47 ms | 18.81 ms | 3.84 ms | 213.1 ms | 274.1 ms | 4.199 | 180.54 KB |
| EachHttpClient    | 465.4 ms | 28.72 ms | 42.98 ms | 7.85 ms | 394.2 ms | 580.5 ms | 2.149 |  280.5 KB |
