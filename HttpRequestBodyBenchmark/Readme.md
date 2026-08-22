# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]  : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  26.56 ns | 0.201 ns | 1.031 ns | 0.061 ns |  22.70 ns |  29.84 ns | 37,656,257.5 | 0.0325 |     136 B |
| GetRequestBodyRent         |  29.50 ns | 0.228 ns | 1.163 ns | 0.069 ns |  26.68 ns |  33.46 ns | 33,901,744.5 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 160.46 ns | 1.416 ns | 7.190 ns | 0.426 ns | 148.95 ns | 177.60 ns |  6,232,094.1 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 188.95 ns | 1.378 ns | 7.132 ns | 0.415 ns | 175.04 ns | 210.20 ns |  5,292,542.3 | 0.1471 |     616 B |
