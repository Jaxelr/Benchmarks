# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]  : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  24.19 ns | 0.336 ns | 1.739 ns | 0.101 ns |  21.11 ns |  28.19 ns | 41,337,958.8 | 0.0325 |     136 B |
| GetRequestBodyRent         |  28.16 ns | 0.230 ns | 1.170 ns | 0.069 ns |  26.12 ns |  32.39 ns | 35,507,364.6 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 151.34 ns | 0.446 ns | 2.237 ns | 0.134 ns | 146.09 ns | 159.90 ns |  6,607,479.6 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 180.40 ns | 0.797 ns | 4.005 ns | 0.240 ns | 176.09 ns | 198.82 ns |  5,543,109.0 | 0.1471 |     616 B |
