# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]    : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr   | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|---------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 328.5 ms |  9.34 ms | 12.79 ms |  2.51 ms | 308.0 ms | 359.6 ms | 3.045 | 222.09 KB |
| HttpClientFactory | 356.0 ms | 60.30 ms | 88.38 ms | 16.41 ms | 269.4 ms | 587.9 ms | 2.809 |  223.6 KB |
| EachHttpClient    | 617.4 ms | 21.81 ms | 30.57 ms |  5.88 ms | 560.3 ms | 673.4 ms | 1.620 |  236.3 KB |
