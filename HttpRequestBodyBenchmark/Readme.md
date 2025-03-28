# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]  : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error     | StdDev     | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|----------:|-----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  28.43 ns |  0.769 ns |   3.871 ns | 0.231 ns |  22.36 ns |  43.14 ns | 35,169,769.8 | 0.0216 |     136 B |
| GetRequestBodyRent         |  93.63 ns |  7.411 ns |  38.227 ns | 2.229 ns |  44.82 ns | 146.69 ns | 10,680,132.5 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 259.60 ns | 13.222 ns |  68.324 ns | 3.978 ns | 153.28 ns | 460.55 ns |  3,852,106.0 | 0.1068 |     672 B |
| RunMultipleThreadsBodyRent | 376.78 ns | 25.243 ns | 127.699 ns | 7.591 ns | 213.43 ns | 741.28 ns |  2,654,097.4 | 0.1068 |     672 B |
