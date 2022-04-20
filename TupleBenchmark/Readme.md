# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]   : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  ShortRun : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|     Method | item1 |                item2 |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | Ratio | RatioSD |  Gen 0 | Allocated |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|------:|--------:|-------:|----------:|
| ValueTuple |     4 |          Random Text | 1.218 ns | 0.6805 ns | 0.0373 ns | 0.0215 ns | 1.194 ns | 1.197 ns | 1.199 ns | 1.230 ns | 1.261 ns | 820,854,501.5 |  0.82 |    0.03 |      - |         - |
| TupleSruct |     4 |          Random Text | 1.487 ns | 0.3248 ns | 0.0178 ns | 0.0103 ns | 1.469 ns | 1.479 ns | 1.489 ns | 1.496 ns | 1.504 ns | 672,465,457.0 |  1.00 |    0.00 |      - |         - |
| TupleClass |     4 |          Random Text | 4.462 ns | 2.9434 ns | 0.1613 ns | 0.0931 ns | 4.317 ns | 4.375 ns | 4.433 ns | 4.534 ns | 4.635 ns | 224,138,588.2 |  3.00 |    0.09 | 0.0076 |      32 B |
|            |       |                      |          |           |           |           |          |          |          |          |          |               |       |         |        |           |
| TupleSruct |   101 | XXXXXXXXXXXXXXXXXXXX | 1.136 ns | 0.2499 ns | 0.0137 ns | 0.0079 ns | 1.123 ns | 1.129 ns | 1.134 ns | 1.142 ns | 1.150 ns | 880,347,063.7 |  1.00 |    0.00 |      - |         - |
| ValueTuple |   101 | XXXXXXXXXXXXXXXXXXXX | 1.182 ns | 0.1884 ns | 0.0103 ns | 0.0060 ns | 1.173 ns | 1.176 ns | 1.180 ns | 1.186 ns | 1.193 ns | 846,241,346.8 |  1.04 |    0.01 |      - |         - |
| TupleClass |   101 | XXXXXXXXXXXXXXXXXXXX | 4.254 ns | 1.5608 ns | 0.0856 ns | 0.0494 ns | 4.191 ns | 4.205 ns | 4.219 ns | 4.285 ns | 4.351 ns | 235,083,995.5 |  3.75 |    0.10 | 0.0076 |      32 B |
