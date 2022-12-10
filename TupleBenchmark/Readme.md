# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |      Mean |     Error |    StdDev |    StdErr |       Min |       Max |          Op/s | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple |     4 |          Random Text |  2.625 ns |  1.821 ns | 0.0998 ns | 0.0576 ns |  2.537 ns |  2.733 ns | 380,956,781.0 |  0.96 |      - |         - |          NA |
| TupleSruct |     4 |          Random Text |  2.753 ns |  4.919 ns | 0.2696 ns | 0.1557 ns |  2.558 ns |  3.061 ns | 363,256,033.0 |  1.00 |      - |         - |          NA |
| TupleClass |     4 |          Random Text | 18.048 ns | 19.494 ns | 1.0685 ns | 0.6169 ns | 17.242 ns | 19.260 ns |  55,407,326.1 |  6.61 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |               |       |        |           |             |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX |  2.111 ns |  2.590 ns | 0.1419 ns | 0.0820 ns |  1.989 ns |  2.267 ns | 473,598,555.4 |  1.00 |      - |         - |          NA |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX |  2.937 ns |  7.878 ns | 0.4318 ns | 0.2493 ns |  2.537 ns |  3.395 ns | 340,460,369.1 |  1.40 |      - |         - |          NA |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 14.324 ns | 71.281 ns | 3.9072 ns | 2.2558 ns | 10.063 ns | 17.739 ns |  69,815,033.2 |  6.82 | 0.0051 |      32 B |          NA |
