# HttpRequestBody benchmark

Measuring whats the best way to read the request body as a huge chunk of bytes

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]  : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

```
| Method                     | Mean      | Error    | StdDev    | StdErr   | Min       | Max       | Op/s         | Gen0   | Allocated |
|--------------------------- |----------:|---------:|----------:|---------:|----------:|----------:|-------------:|-------:|----------:|
| GetRequestBodyCopy         |  25.86 ns | 0.329 ns |  1.641 ns | 0.099 ns |  23.98 ns |  31.91 ns | 38,670,176.7 | 0.0216 |     136 B |
| GetRequestBodyRent         |  85.49 ns | 4.475 ns | 22.965 ns | 1.346 ns |  51.75 ns | 161.64 ns | 11,697,654.9 | 0.0216 |     136 B |
| RunMultipleThreadsBodyCopy | 204.43 ns | 5.174 ns | 26.031 ns | 1.556 ns | 160.95 ns | 282.69 ns |  4,891,681.1 | 0.1082 |     680 B |
| RunMultipleThreadsBodyRent | 327.22 ns | 9.208 ns | 46.416 ns | 2.769 ns | 264.32 ns | 525.01 ns |  3,056,027.1 | 0.1082 |     680 B |
