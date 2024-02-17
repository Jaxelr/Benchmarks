# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.102
  [Host]  : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  33.63 ns | 0.971 ns |  4.875 ns | 0.292 ns |  26.14 ns |  52.71 ns | 29,736,584.0 | 0.0216 |     136 B |
| GetRequestBodyRent         |  85.91 ns | 8.951 ns | 45.446 ns | 2.692 ns |  55.59 ns | 288.13 ns | 11,640,215.8 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 198.05 ns | 2.850 ns | 14.598 ns | 0.857 ns | 170.05 ns | 243.68 ns |  5,049,294.7 | 0.1082 |     680 B |
| RunMultipleThreadsBodyRent | 316.64 ns | 4.596 ns | 23.082 ns | 1.382 ns | 276.80 ns | 416.81 ns |  3,158,200.2 | 0.1082 |     680 B |
