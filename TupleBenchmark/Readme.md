# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.959 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]   : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |      Mean |      Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |------ |--------------------- |----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
| TupleSruct |     4 |          Random Text |  3.572 ns |  3.3011 ns | 0.1809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| ValueTuple |     4 |          Random Text |  3.795 ns |  3.2034 ns | 0.1756 ns |  1.06 |    0.05 |      - |     - |     - |         - |
| TupleClass |     4 |          Random Text | 13.622 ns | 14.0459 ns | 0.7699 ns |  3.81 |    0.07 | 0.0204 |     - |     - |      32 B |
|            |       |                      |           |            |           |       |         |        |       |       |           |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX |  2.853 ns |  5.6567 ns | 0.3101 ns |  0.88 |    0.08 |      - |     - |     - |         - |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX |  3.241 ns |  0.9404 ns | 0.0515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 16.155 ns | 28.8856 ns | 1.5833 ns |  4.99 |    0.56 | 0.0204 |     - |     - |      32 B |
