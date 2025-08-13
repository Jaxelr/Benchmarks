# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]    : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  MediumRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev    | StdErr   | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|----------:|---------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 192.6 ms |  2.73 ms |   3.83 ms |  0.74 ms | 185.7 ms | 202.3 ms | 5.193 | 119.38 KB |
| HttpClientFactory | 299.4 ms | 68.87 ms | 100.95 ms | 18.75 ms | 184.5 ms | 596.8 ms | 3.340 | 120.98 KB |
| EachHttpClient    | 379.2 ms | 10.64 ms |  15.26 ms |  2.88 ms | 357.3 ms | 429.6 ms | 2.637 | 157.55 KB |
