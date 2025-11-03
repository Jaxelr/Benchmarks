# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]  : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  18.11 ns | 0.202 ns |  1.039 ns | 0.061 ns |  16.47 ns |  20.98 ns | 55,209,174.0 | 0.0325 |     136 B |
| GetRequestBodyRent         |  30.52 ns | 0.157 ns |  0.782 ns | 0.047 ns |  29.70 ns |  33.89 ns | 32,761,241.0 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 127.86 ns | 1.772 ns |  9.079 ns | 0.533 ns | 121.17 ns | 148.96 ns |  7,821,145.1 | 0.1605 |     672 B |
| RunMultipleThreadsBodyRent | 191.25 ns | 2.528 ns | 12.973 ns | 0.761 ns | 177.31 ns | 229.39 ns |  5,228,659.7 | 0.1602 |     672 B |
