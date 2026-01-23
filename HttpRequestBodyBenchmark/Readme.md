# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]  : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  21.03 ns | 0.121 ns | 0.622 ns | 0.037 ns |  19.85 ns |  23.52 ns | 47,545,852.2 | 0.0325 |     136 B |
| GetRequestBodyRent         |  24.84 ns | 0.036 ns | 0.178 ns | 0.011 ns |  24.55 ns |  25.56 ns | 40,253,029.4 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 158.95 ns | 1.903 ns | 9.712 ns | 0.572 ns | 140.22 ns | 187.30 ns |  6,291,428.3 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 180.52 ns | 1.509 ns | 7.675 ns | 0.454 ns | 174.46 ns | 211.27 ns |  5,539,577.4 | 0.1471 |     616 B |
