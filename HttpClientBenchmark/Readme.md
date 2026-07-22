# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]    : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 227.9 ms |  6.03 ms |  8.84 ms | 1.64 ms | 213.4 ms | 248.9 ms | 4.387 | 158.08 KB |
| HttpClientFactory | 245.2 ms |  9.95 ms | 14.27 ms | 2.70 ms | 228.9 ms | 277.9 ms | 4.078 | 137.59 KB |
| EachHttpClient    | 450.7 ms | 18.94 ms | 28.35 ms | 5.18 ms | 411.0 ms | 510.2 ms | 2.219 | 270.22 KB |
