# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|----------- |------ |--------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|
| TupleSruct |     4 |          Random Text | 1.435 ns | 0.2326 ns | 0.0128 ns |  1.00 |    0.00 |      - |         - |
| ValueTuple |     4 |          Random Text | 1.683 ns | 2.4469 ns | 0.1341 ns |  1.17 |    0.09 |      - |         - |
| TupleClass |     4 |          Random Text | 4.253 ns | 2.5884 ns | 0.1419 ns |  2.96 |    0.07 | 0.0076 |      32 B |
|            |       |                      |          |           |           |       |         |        |           |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 1.499 ns | 1.3833 ns | 0.0758 ns |  1.00 |    0.00 |      - |         - |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 1.557 ns | 0.1637 ns | 0.0090 ns |  1.04 |    0.05 |      - |         - |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 4.547 ns | 4.0747 ns | 0.2233 ns |  3.04 |    0.06 | 0.0076 |      32 B |
