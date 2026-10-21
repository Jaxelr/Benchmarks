# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]  : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  25.32 ns | 0.616 ns | 3.106 ns | 0.185 ns |  19.81 ns |  31.61 ns | 39,502,234.8 | 0.0325 |     136 B |
| GetRequestBodyRent         |  27.52 ns | 0.188 ns | 0.963 ns | 0.057 ns |  25.48 ns |  30.56 ns | 36,330,857.3 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 156.04 ns | 0.565 ns | 2.772 ns | 0.170 ns | 149.99 ns | 166.10 ns |  6,408,569.7 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 181.00 ns | 0.527 ns | 2.694 ns | 0.158 ns | 174.97 ns | 193.78 ns |  5,525,001.9 | 0.1471 |     616 B |
