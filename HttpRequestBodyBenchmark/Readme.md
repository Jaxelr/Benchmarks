# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  19.12 ns | 0.326 ns |  1.663 ns | 0.098 ns |  17.05 ns |  24.74 ns | 52,292,130.7 | 0.0325 |     136 B |
| GetRequestBodyRent         |  35.71 ns | 0.731 ns |  3.673 ns | 0.220 ns |  31.68 ns |  41.47 ns | 28,003,004.1 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 129.26 ns | 0.507 ns |  2.522 ns | 0.152 ns | 126.24 ns | 140.24 ns |  7,736,446.3 | 0.1605 |     672 B |
| RunMultipleThreadsBodyRent | 213.65 ns | 3.246 ns | 16.625 ns | 0.976 ns | 200.45 ns | 298.38 ns |  4,680,479.1 | 0.1605 |     672 B |
