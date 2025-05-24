# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]  : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  24.85 ns | 0.364 ns |  1.782 ns | 0.109 ns |  22.40 ns |  31.21 ns | 40,238,437.9 | 0.0217 |     136 B |
| GetRequestBodyRent         |  36.32 ns | 0.323 ns |  1.602 ns | 0.097 ns |  34.96 ns |  43.07 ns | 27,536,213.8 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 158.97 ns | 0.943 ns |  4.638 ns | 0.283 ns | 152.24 ns | 175.13 ns |  6,290,664.2 | 0.1070 |     672 B |
| RunMultipleThreadsBodyRent | 311.48 ns | 7.687 ns | 39.238 ns | 2.312 ns | 255.45 ns | 493.47 ns |  3,210,486.4 | 0.1068 |     672 B |
