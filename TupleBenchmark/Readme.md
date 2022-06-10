# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | Ratio | RatioSD |  Gen 0 | Allocated |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|------:|--------:|-------:|----------:|
| TupleSruct |     4 |          Random Text | 1.687 ns |  2.376 ns | 0.1302 ns | 0.0752 ns | 1.548 ns | 1.627 ns | 1.706 ns | 1.756 ns | 1.807 ns | 592,733,277.0 |  1.00 |    0.00 |      - |         - |
| ValueTuple |     4 |          Random Text | 2.270 ns |  1.679 ns | 0.0920 ns | 0.0531 ns | 2.213 ns | 2.217 ns | 2.221 ns | 2.299 ns | 2.376 ns | 440,527,900.7 |  1.35 |    0.16 |      - |         - |
| TupleClass |     4 |          Random Text | 5.666 ns | 12.520 ns | 0.6863 ns | 0.3962 ns | 5.150 ns | 5.277 ns | 5.404 ns | 5.924 ns | 6.445 ns | 176,484,296.3 |  3.36 |    0.39 | 0.0051 |      32 B |
|            |       |                      |          |           |           |           |          |          |          |          |          |               |       |         |        |           |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 1.666 ns |  2.288 ns | 0.1254 ns | 0.0724 ns | 1.540 ns | 1.603 ns | 1.667 ns | 1.729 ns | 1.791 ns | 600,312,340.3 |  0.88 |    0.13 |      - |         - |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 1.931 ns |  6.940 ns | 0.3804 ns | 0.2196 ns | 1.502 ns | 1.783 ns | 2.065 ns | 2.146 ns | 2.227 ns | 517,774,175.0 |  1.00 |    0.00 |      - |         - |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 5.046 ns |  1.971 ns | 0.1080 ns | 0.0624 ns | 4.922 ns | 5.011 ns | 5.101 ns | 5.109 ns | 5.116 ns | 198,164,627.7 |  2.69 |    0.62 | 0.0051 |      32 B |
