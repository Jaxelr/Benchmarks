# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]  : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyRent         |  36.42 ns | 0.313 ns |  1.571 ns | 0.094 ns |  34.75 ns |  43.39 ns | 27,456,207.5 | 0.0216 |     136 B |
| GetRequestBodyCopy         |  37.20 ns | 2.953 ns | 14.667 ns | 0.888 ns |  22.94 ns |  67.08 ns | 26,879,336.2 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 162.89 ns | 1.800 ns |  8.959 ns | 0.541 ns | 151.88 ns | 194.83 ns |  6,139,022.3 | 0.1068 |     672 B |
| RunMultipleThreadsBodyRent | 214.85 ns | 1.942 ns |  9.682 ns | 0.584 ns | 204.93 ns | 245.47 ns |  4,654,455.5 | 0.1068 |     672 B |
