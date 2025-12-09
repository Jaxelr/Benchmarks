# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]    : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 244.5 ms | 19.10 ms | 27.39 ms | 5.18 ms | 214.0 ms | 339.6 ms | 4.090 | 128.56 KB |
| StaticHttpClient  | 283.3 ms | 33.42 ms | 44.61 ms | 8.92 ms | 223.4 ms | 354.5 ms | 3.530 | 127.76 KB |
| EachHttpClient    | 446.1 ms | 29.17 ms | 42.76 ms | 7.94 ms | 399.8 ms | 543.8 ms | 2.242 | 165.82 KB |
