# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.302
  [Host]  : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  29.94 ns | 1.132 ns |  5.662 ns | 0.340 ns |  23.80 ns |  51.80 ns | 33,395,518.7 | 0.0216 |     136 B |
| GetRequestBodyRent         |  48.83 ns | 1.525 ns |  7.684 ns | 0.458 ns |  36.65 ns |  74.05 ns | 20,479,744.4 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 197.54 ns | 5.994 ns | 29.939 ns | 1.802 ns | 167.05 ns | 306.22 ns |  5,062,141.1 | 0.1070 |     672 B |
| RunMultipleThreadsBodyRent | 244.89 ns | 6.157 ns | 30.923 ns | 1.851 ns | 207.82 ns | 373.12 ns |  4,083,518.3 | 0.1070 |     672 B |
