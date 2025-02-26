# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]  : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyRent         |  38.11 ns | 0.526 ns |  2.663 ns | 0.158 ns |  34.97 ns |  48.25 ns | 26,237,187.6 | 0.0216 |     136 B |
| GetRequestBodyCopy         |  43.50 ns | 2.372 ns | 11.979 ns | 0.713 ns |  24.23 ns |  67.90 ns | 22,990,117.4 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 176.53 ns | 6.432 ns | 32.005 ns | 1.933 ns | 153.36 ns | 331.13 ns |  5,664,804.6 | 0.1070 |     672 B |
| RunMultipleThreadsBodyRent | 232.80 ns | 4.896 ns | 24.947 ns | 1.473 ns | 205.05 ns | 326.74 ns |  4,295,553.2 | 0.1070 |     672 B |
