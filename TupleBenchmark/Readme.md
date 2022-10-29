# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |     Error |    StdDev |    StdErr |      Min |      Max |          Op/s | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| TupleSruct |     4 |          Random Text | 1.747 ns |  2.236 ns | 0.1226 ns | 0.0708 ns | 1.614 ns | 1.855 ns | 572,466,558.2 |  1.00 |      - |         - |          NA |
| ValueTuple |     4 |          Random Text | 3.034 ns |  4.133 ns | 0.2266 ns | 0.1308 ns | 2.865 ns | 3.292 ns | 329,552,883.8 |  1.75 |      - |         - |          NA |
| TupleClass |     4 |          Random Text | 5.814 ns |  8.881 ns | 0.4868 ns | 0.2811 ns | 5.479 ns | 6.372 ns | 171,997,757.9 |  3.34 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |               |       |        |           |             |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 2.183 ns |  6.647 ns | 0.3643 ns | 0.2104 ns | 1.968 ns | 2.603 ns | 458,166,856.6 |  1.00 |      - |         - |          NA |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 2.549 ns |  2.453 ns | 0.1345 ns | 0.0776 ns | 2.409 ns | 2.677 ns | 392,253,637.9 |  1.19 |      - |         - |          NA |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 6.154 ns | 11.547 ns | 0.6329 ns | 0.3654 ns | 5.624 ns | 6.855 ns | 162,500,219.5 |  2.87 | 0.0051 |      32 B |          NA |
