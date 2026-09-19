# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]    : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 255.2 ms | 10.03 ms | 13.73 ms | 2.69 ms | 238.9 ms | 302.6 ms | 3.918 | 176.05 KB |
| HttpClientFactory | 265.8 ms | 14.11 ms | 19.78 ms | 3.81 ms | 240.1 ms | 311.7 ms | 3.762 | 127.91 KB |
| EachHttpClient    | 489.3 ms | 17.36 ms | 25.44 ms | 4.72 ms | 441.0 ms | 549.5 ms | 2.044 | 164.52 KB |
