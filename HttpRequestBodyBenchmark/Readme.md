# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]  : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  20.89 ns | 0.113 ns | 0.576 ns | 0.034 ns |  19.97 ns |  22.92 ns | 47,875,983.1 | 0.0325 |     136 B |
| GetRequestBodyRent         |  25.82 ns | 0.137 ns | 0.690 ns | 0.041 ns |  25.06 ns |  28.54 ns | 38,723,125.3 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 160.55 ns | 1.663 ns | 8.431 ns | 0.500 ns | 147.39 ns | 177.17 ns |  6,228,408.7 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 206.98 ns | 1.255 ns | 6.392 ns | 0.377 ns | 196.54 ns | 231.51 ns |  4,831,288.8 | 0.1471 |     616 B |
