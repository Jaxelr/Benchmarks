# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]  : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a
  LongRun : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a

Job=LongRun  IterationCount=100  LaunchCount=3
WarmupCount=15

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  22.06 ns | 0.181 ns |  0.932 ns | 0.054 ns |  20.40 ns |  24.17 ns | 45,329,502.4 | 0.0325 |     136 B |
| GetRequestBodyRent         |  26.30 ns | 0.232 ns |  1.186 ns | 0.070 ns |  24.78 ns |  29.54 ns | 38,022,969.0 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 157.87 ns | 0.794 ns |  4.115 ns | 0.239 ns | 151.11 ns | 170.94 ns |  6,334,426.5 | 0.1471 |     616 B |
| RunMultipleThreadsBodyRent | 200.63 ns | 4.271 ns | 21.879 ns | 1.285 ns | 181.69 ns | 240.07 ns |  4,984,314.5 | 0.1471 |     616 B |
