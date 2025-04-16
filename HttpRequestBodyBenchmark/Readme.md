# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]  : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error     | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|----------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  41.28 ns |  1.864 ns |  9.666 ns | 0.561 ns |  26.69 ns |  69.46 ns | 24,225,912.8 | 0.0216 |     136 B |
| GetRequestBodyRent         |  46.35 ns |  2.380 ns | 11.998 ns | 0.716 ns |  33.50 ns |  86.25 ns | 21,573,814.0 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 182.78 ns |  5.353 ns | 27.225 ns | 1.610 ns | 150.87 ns | 279.34 ns |  5,471,102.6 | 0.1070 |     672 B |
| RunMultipleThreadsBodyRent | 299.65 ns | 10.604 ns | 54.316 ns | 3.190 ns | 202.14 ns | 459.47 ns |  3,337,217.0 | 0.1068 |     672 B |
