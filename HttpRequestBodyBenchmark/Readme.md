# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]  : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  21.41 ns | 0.138 ns |  0.702 ns | 0.042 ns |  20.54 ns |  24.24 ns | 46,703,770.7 | 0.0325 |     136 B |
| GetRequestBodyRent         |  30.43 ns | 1.296 ns |  6.559 ns | 0.390 ns |  24.74 ns |  41.01 ns | 32,861,563.6 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 153.43 ns | 0.544 ns |  2.717 ns | 0.164 ns | 149.11 ns | 163.06 ns |  6,517,769.6 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 199.74 ns | 5.754 ns | 28.580 ns | 1.730 ns | 175.58 ns | 248.80 ns |  5,006,468.8 | 0.1469 |     616 B |
