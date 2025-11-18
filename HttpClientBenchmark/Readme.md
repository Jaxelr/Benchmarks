# HttpClient benchmark

I'm measuring how costly is the creation of an Http Client per request vs statics or http client factory.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]    : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  MediumRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

```
| Method            | Mean     | Error    | StdDev   | StdErr  | Min      | Max      | Op/s  | Allocated |
|------------------ |---------:|---------:|---------:|--------:|---------:|---------:|------:|----------:|
| HttpClientFactory | 229.9 ms |  9.87 ms | 13.84 ms | 2.66 ms | 207.9 ms | 257.3 ms | 4.350 | 128.81 KB |
| StaticHttpClient  | 261.2 ms | 27.15 ms | 39.80 ms | 7.39 ms | 210.2 ms | 370.3 ms | 3.828 | 127.66 KB |
| EachHttpClient    | 449.6 ms | 36.06 ms | 52.86 ms | 9.82 ms | 376.9 ms | 610.2 ms | 2.224 | 165.72 KB |
