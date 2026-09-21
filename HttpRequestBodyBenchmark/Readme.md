# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  26.13 ns | 0.204 ns | 1.030 ns | 0.061 ns |  23.11 ns |  28.83 ns | 38,270,763.3 | 0.0325 |     136 B |
| GetRequestBodyRent         |  31.28 ns | 0.450 ns | 2.319 ns | 0.135 ns |  26.16 ns |  40.11 ns | 31,970,718.5 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 171.61 ns | 1.640 ns | 8.115 ns | 0.493 ns | 152.45 ns | 193.18 ns |  5,827,073.3 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 185.17 ns | 1.168 ns | 6.058 ns | 0.352 ns | 175.06 ns | 204.39 ns |  5,400,555.7 | 0.1471 |     616 B |
