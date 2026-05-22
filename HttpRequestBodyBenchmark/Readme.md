# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]  : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  22.75 ns | 0.535 ns |  2.724 ns | 0.161 ns |  19.82 ns |  29.95 ns | 43,963,746.8 | 0.0325 |     136 B |
| GetRequestBodyRent         |  29.72 ns | 0.327 ns |  1.693 ns | 0.098 ns |  25.68 ns |  34.34 ns | 33,651,906.7 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 170.06 ns | 1.914 ns |  9.752 ns | 0.576 ns | 154.05 ns | 200.48 ns |  5,880,421.8 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 188.63 ns | 2.205 ns | 11.373 ns | 0.663 ns | 176.03 ns | 230.53 ns |  5,301,436.4 | 0.1471 |     616 B |
