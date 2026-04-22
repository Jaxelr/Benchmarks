# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]  : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  23.33 ns | 0.360 ns |  1.840 ns | 0.108 ns |  19.98 ns |  28.53 ns | 42,862,781.7 | 0.0325 |     136 B |
| GetRequestBodyRent         |  28.84 ns | 0.358 ns |  1.813 ns | 0.108 ns |  26.04 ns |  35.81 ns | 34,670,127.8 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 166.50 ns | 2.151 ns | 10.980 ns | 0.647 ns | 148.02 ns | 210.24 ns |  6,006,163.5 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 213.58 ns | 3.071 ns | 15.869 ns | 0.924 ns | 179.32 ns | 236.25 ns |  4,682,185.5 | 0.1471 |     616 B |
