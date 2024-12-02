# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]  : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error     | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|----------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  50.56 ns |  2.160 ns |  11.26 ns | 0.650 ns |  29.13 ns |  81.10 ns | 19,778,377.7 | 0.0216 |     136 B |
| GetRequestBodyRent         |  80.78 ns |  5.360 ns |  27.69 ns | 1.612 ns |  37.21 ns | 140.08 ns | 12,378,780.5 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 273.08 ns | 14.487 ns |  74.08 ns | 4.358 ns | 153.64 ns | 498.37 ns |  3,661,917.1 | 0.1068 |     672 B |
| RunMultipleThreadsBodyRent | 428.24 ns | 28.591 ns | 149.01 ns | 8.603 ns | 204.50 ns | 722.87 ns |  2,335,165.0 | 0.1068 |     672 B |
