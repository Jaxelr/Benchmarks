# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]  : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  20.77 ns | 0.101 ns |  0.503 ns | 0.030 ns |  19.84 ns |  22.74 ns | 48,137,694.0 | 0.0325 |     136 B |
| GetRequestBodyRent         |  26.83 ns | 0.533 ns |  2.709 ns | 0.160 ns |  24.75 ns |  36.17 ns | 37,273,022.3 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 173.95 ns | 3.621 ns | 17.713 ns | 1.088 ns | 149.24 ns | 211.68 ns |  5,748,691.3 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 181.03 ns | 1.062 ns |  5.167 ns | 0.319 ns | 175.47 ns | 196.48 ns |  5,524,093.6 | 0.1471 |     616 B |
