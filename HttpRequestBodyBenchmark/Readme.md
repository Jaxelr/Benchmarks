# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]  : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  LongRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  32.26 ns | 0.088 ns |  0.450 ns | 0.026 ns |  31.27 ns |  33.42 ns | 30,998,941.2 | 0.0325 |     136 B |
| GetRequestBodyRent         |  60.00 ns | 0.114 ns |  0.585 ns | 0.034 ns |  58.78 ns |  61.38 ns | 16,666,383.8 | 0.0324 |     136 B |
| RunMultipleThreadsBodyCopy | 262.74 ns | 2.200 ns | 10.887 ns | 0.661 ns | 256.26 ns | 365.44 ns |  3,806,095.4 | 0.1602 |     672 B |
| RunMultipleThreadsBodyRent | 386.93 ns | 2.582 ns | 13.411 ns | 0.777 ns | 374.55 ns | 408.89 ns |  2,584,421.3 | 0.1602 |     672 B |

