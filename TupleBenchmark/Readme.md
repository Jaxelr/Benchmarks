# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|------:|--------:|-------:|----------:|------------:|
| ValueTuple |     4 |          Random Text | 1.898 ns |  9.194 ns | 0.5040 ns | 0.2910 ns | 1.502 ns | 1.615 ns | 1.727 ns | 2.096 ns | 2.465 ns | 526,811,895.4 |  0.94 |    0.30 |      - |         - |          NA |
| TupleSruct |     4 |          Random Text | 2.037 ns |  1.824 ns | 0.1000 ns | 0.0577 ns | 1.925 ns | 1.998 ns | 2.071 ns | 2.094 ns | 2.117 ns | 490,831,191.6 |  1.00 |    0.00 |      - |         - |          NA |
| TupleClass |     4 |          Random Text | 6.719 ns | 20.907 ns | 1.1460 ns | 0.6616 ns | 6.047 ns | 6.058 ns | 6.068 ns | 7.056 ns | 8.043 ns | 148,823,559.9 |  3.30 |    0.53 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |          |          |          |               |       |         |        |           |             |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 2.578 ns |  1.143 ns | 0.0626 ns | 0.0362 ns | 2.536 ns | 2.542 ns | 2.547 ns | 2.599 ns | 2.650 ns | 387,908,827.6 |  0.84 |    0.04 |      - |         - |          NA |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 3.082 ns |  1.310 ns | 0.0718 ns | 0.0415 ns | 3.000 ns | 3.057 ns | 3.114 ns | 3.123 ns | 3.132 ns | 324,470,009.8 |  1.00 |    0.00 |      - |         - |          NA |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 9.178 ns |  2.976 ns | 0.1631 ns | 0.0942 ns | 9.029 ns | 9.091 ns | 9.152 ns | 9.252 ns | 9.352 ns | 108,960,071.5 |  2.98 |    0.12 | 0.0051 |      32 B |          NA |
