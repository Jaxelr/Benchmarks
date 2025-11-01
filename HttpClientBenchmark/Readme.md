# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]    : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 207.4 ms |  3.81 ms |  5.59 ms | 1.04 ms | 197.7 ms | 219.9 ms | 4.821 | 129.04 KB |
| StaticHttpClient  | 227.6 ms | 14.38 ms | 20.62 ms | 3.90 ms | 200.5 ms | 257.5 ms | 4.393 |  127.8 KB |
| EachHttpClient    | 381.2 ms |  6.32 ms |  9.06 ms | 1.71 ms | 365.4 ms | 399.2 ms | 2.623 | 165.97 KB |
