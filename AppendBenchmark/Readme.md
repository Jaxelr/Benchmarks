# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |        Error |    StdDev | Ratio | RatioSD |   Gen 0 |   Gen 1 | Allocated |
|------------- |------------- |------ |-----------:|-------------:|----------:|------:|--------:|--------:|--------:|----------:|
| AppendCopyTo |  Int32[1000] |     4 |   252.8 ns |    105.51 ns |   5.78 ns |  0.37 |    0.10 |  0.9632 |       - |      4 KB |
| AppendConcat |  Int32[1000] |     4 |   350.8 ns |     95.93 ns |   5.26 ns |  0.52 |    0.13 |  0.9975 |       - |      4 KB |
|       Append |  Int32[1000] |     4 |   713.0 ns |  3,598.05 ns | 197.22 ns |  1.00 |    0.00 |  0.9632 |       - |      4 KB |
| AppendToList |  Int32[1000] |     4 |   875.0 ns |    223.59 ns |  12.26 ns |  1.29 |    0.33 |  3.8452 |       - |     16 KB |
| AppendCopyTo | Int32[10000] |     4 | 2,583.4 ns |  2,094.05 ns | 114.78 ns |  3.80 |    0.98 |  9.5215 |  0.0038 |     39 KB |
| AppendConcat | Int32[10000] |     4 | 2,688.3 ns |  2,157.36 ns | 118.25 ns |  3.92 |    0.83 |  9.5215 |  0.0038 |     39 KB |
|       Append | Int32[10000] |     4 | 4,878.4 ns |  3,113.33 ns | 170.65 ns |  7.12 |    1.54 |  9.5215 |  0.0076 |     39 KB |
| AppendToList | Int32[10000] |     4 | 9,416.0 ns |  9,693.00 ns | 531.31 ns | 13.70 |    2.70 | 37.9639 | 12.6495 |    156 KB |
|              |              |       |            |              |           |       |         |         |         |           |
| AppendCopyTo |  Int32[1000] |   101 |   281.0 ns |    878.84 ns |  48.17 ns |  0.39 |    0.12 |  0.9632 |       - |      4 KB |
| AppendConcat |  Int32[1000] |   101 |   375.6 ns |    709.35 ns |  38.88 ns |  0.52 |    0.12 |  0.9975 |       - |      4 KB |
|       Append |  Int32[1000] |   101 |   733.7 ns |  1,648.40 ns |  90.35 ns |  1.00 |    0.00 |  0.9632 |       - |      4 KB |
| AppendToList |  Int32[1000] |   101 |   998.0 ns |  1,379.22 ns |  75.60 ns |  1.38 |    0.29 |  3.8452 |       - |     16 KB |
| AppendCopyTo | Int32[10000] |   101 | 2,877.5 ns |  8,950.22 ns | 490.59 ns |  3.98 |    0.89 |  9.5215 |  0.0038 |     39 KB |
| AppendConcat | Int32[10000] |   101 | 3,422.9 ns | 10,397.95 ns | 569.95 ns |  4.72 |    1.00 |  9.5215 |  0.0038 |     39 KB |
|       Append | Int32[10000] |   101 | 5,208.0 ns |    649.30 ns |  35.59 ns |  7.17 |    0.93 |  9.5215 |  0.0076 |     39 KB |
| AppendToList | Int32[10000] |   101 | 9,447.3 ns | 10,177.81 ns | 557.88 ns | 13.08 |    2.48 | 37.9639 | 12.6495 |    156 KB |
