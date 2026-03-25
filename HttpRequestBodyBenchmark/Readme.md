# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]  : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  19.36 ns | 0.189 ns | 0.964 ns | 0.057 ns |  17.66 ns |  22.28 ns | 51,644,659.4 | 0.0325 |     136 B |
| GetRequestBodyRent         |  25.41 ns | 0.098 ns | 0.502 ns | 0.029 ns |  24.62 ns |  26.76 ns | 39,350,656.7 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 154.92 ns | 0.848 ns | 4.342 ns | 0.255 ns | 148.06 ns | 166.22 ns |  6,454,770.3 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 180.98 ns | 0.590 ns | 3.024 ns | 0.178 ns | 175.51 ns | 186.75 ns |  5,525,429.7 | 0.1471 |     616 B |
