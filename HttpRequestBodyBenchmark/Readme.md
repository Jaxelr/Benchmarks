# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]  : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error     | StdDev     | StdErr    | Min       | Max         | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|----------:|-----------:|----------:|----------:|------------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  30.07 ns |  0.802 ns |   3.948 ns |  0.241 ns |  25.13 ns |    45.46 ns | 33,252,897.1 | 0.0216 |     136 B |
| GetRequestBodyRent         |  60.21 ns |  1.073 ns |   5.397 ns |  0.323 ns |  50.91 ns |    76.61 ns | 16,609,203.7 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 255.00 ns | 12.335 ns |  61.723 ns |  3.709 ns | 174.22 ns |   539.86 ns |  3,921,537.2 | 0.1082 |     680 B |
| RunMultipleThreadsBodyRent | 605.69 ns | 62.291 ns | 313.984 ns | 18.731 ns | 309.33 ns | 1,279.05 ns |  1,650,999.2 | 0.1082 |     680 B |
