# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]  : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev   | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|---------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  18.27 ns | 0.133 ns | 0.677 ns | 0.040 ns |  17.32 ns |  20.82 ns | 54,736,367.5 | 0.0325 |     136 B |
| GetRequestBodyRent         |  37.79 ns | 0.698 ns | 3.632 ns | 0.210 ns |  32.05 ns |  47.32 ns | 26,460,944.0 | 0.0325 |     136 B |
| RunMultipleThreadsBodyCopy | 155.40 ns | 0.963 ns | 5.009 ns | 0.290 ns | 143.29 ns | 167.02 ns |  6,434,939.6 | 0.1605 |     672 B |
| RunMultipleThreadsBodyRent | 205.58 ns | 1.320 ns | 6.604 ns | 0.397 ns | 196.52 ns | 220.30 ns |  4,864,271.9 | 0.1605 |     672 B |
