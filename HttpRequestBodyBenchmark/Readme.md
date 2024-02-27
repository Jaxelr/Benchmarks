# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]  : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error     | StdDev     | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|----------:|-----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  36.06 ns |  1.942 ns |   9.313 ns | 0.583 ns |  24.62 ns |  75.34 ns | 27,727,715.9 | 0.0216 |     136 B |
| GetRequestBodyRent         |  73.57 ns |  3.107 ns |  15.548 ns | 0.934 ns |  53.04 ns | 131.33 ns | 13,593,251.8 | 0.0216 |     136 B |
| RunMultipleThreadsBodyRent | 318.01 ns |  6.231 ns |  30.945 ns | 1.873 ns | 275.78 ns | 459.34 ns |  3,144,508.8 | 0.1082 |     680 B |
| RunMultipleThreadsBodyCopy | 492.35 ns | 29.454 ns | 153.506 ns | 8.863 ns | 209.48 ns | 796.55 ns |  2,031,063.0 | 0.1082 |     680 B |
