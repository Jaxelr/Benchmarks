# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]  : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  26.21 ns | 0.505 ns |  2.494 ns | 0.152 ns |  22.95 ns |  34.48 ns | 38,150,285.4 | 0.0217 |     136 B |
| GetRequestBodyRent         |  42.40 ns | 1.291 ns |  6.486 ns | 0.388 ns |  35.56 ns |  70.40 ns | 23,587,421.1 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 177.97 ns | 6.895 ns | 34.757 ns | 2.073 ns | 149.93 ns | 342.36 ns |  5,618,976.5 | 0.1070 |     672 B |
| RunMultipleThreadsBodyRent | 248.16 ns | 8.002 ns | 40.844 ns | 2.407 ns | 213.44 ns | 431.57 ns |  4,029,694.0 | 0.1068 |     672 B |
