# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]    : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| StaticHttpClient  | 280.7 ms | 18.98 ms | 27.82 ms | 5.17 ms | 233.5 ms | 336.4 ms | 3.562 | 126.88 KB |
| HttpClientFactory | 320.9 ms | 28.03 ms | 41.96 ms | 7.66 ms | 259.2 ms | 397.6 ms | 3.116 | 209.78 KB |
| EachHttpClient    | 510.4 ms | 34.25 ms | 51.27 ms | 9.36 ms | 418.8 ms | 617.5 ms | 1.959 | 165.43 KB |
