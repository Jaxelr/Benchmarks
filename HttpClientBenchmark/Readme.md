# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]    : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  MediumRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 220.2 ms |  4.81 ms |  6.89 ms | 1.30 ms | 208.5 ms | 239.9 ms | 4.541 | 127.13 KB |
| StaticHttpClient  | 226.3 ms |  6.49 ms |  9.31 ms | 1.76 ms | 210.7 ms | 250.8 ms | 4.419 | 126.21 KB |
| EachHttpClient    | 409.6 ms | 13.04 ms | 19.52 ms | 3.56 ms | 371.4 ms | 447.5 ms | 2.441 | 164.32 KB |
