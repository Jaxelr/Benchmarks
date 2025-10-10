# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6725)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  19.89 ns | 0.177 ns | 0.907 ns | 0.053 ns |  18.00 ns |  22.71 ns | 50,287,309.8 | 0.0325 |     136 B |
| GetRequestBodyRent         |  36.73 ns | 0.348 ns | 1.804 ns | 0.105 ns |  32.95 ns |  43.36 ns | 27,223,655.3 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 145.13 ns | 0.623 ns | 3.148 ns | 0.187 ns | 140.54 ns | 155.21 ns |  6,890,344.3 | 0.1605 |     672 B |
| RunMultipleThreadsBodyRent | 216.13 ns | 0.842 ns | 4.213 ns | 0.253 ns | 210.50 ns | 232.74 ns |  4,626,796.8 | 0.1602 |     672 B |
