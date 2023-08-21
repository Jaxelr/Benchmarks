# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |        Mean |       Error |      StdDev |    StdErr |         Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |    278.8 ns |    304.9 ns |    16.71 ns |   9.65 ns |    261.7 ns |    295.1 ns | 3,587,080.6 |  0.41 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |    407.4 ns |  1,141.3 ns |    62.56 ns |  36.12 ns |    367.0 ns |    479.4 ns | 2,454,815.5 |  0.60 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |    682.2 ns |    354.7 ns |    19.44 ns |  11.23 ns |    668.8 ns |    704.5 ns | 1,465,856.1 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |  1,020.7 ns |    330.6 ns |    18.12 ns |  10.46 ns |  1,000.0 ns |  1,033.5 ns |   979,702.7 |  1.50 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 |  3,467.0 ns |  1,955.7 ns |   107.20 ns |  61.89 ns |  3,366.4 ns |  3,579.8 ns |   288,431.0 |  5.09 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 |  6,427.5 ns | 16,128.2 ns |   884.04 ns | 510.40 ns |  5,591.4 ns |  7,352.8 ns |   155,580.9 |  9.40 |  6.3667 |      - |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 |  9,061.9 ns |  6,194.8 ns |   339.56 ns | 196.04 ns |  8,679.1 ns |  9,326.6 ns |   110,351.8 | 13.29 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 20,198.6 ns | 19,949.5 ns | 1,093.50 ns | 631.33 ns | 18,965.9 ns | 21,051.6 ns |    49,508.3 | 29.61 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
|              |              |       |             |             |             |           |             |             |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |    261.6 ns |    408.0 ns |    22.36 ns |  12.91 ns |    245.6 ns |    287.2 ns | 3,822,230.0 |  0.39 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |    388.1 ns |    815.9 ns |    44.72 ns |  25.82 ns |    340.4 ns |    429.1 ns | 2,576,545.3 |  0.57 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |    677.4 ns |    392.8 ns |    21.53 ns |  12.43 ns |    661.8 ns |    702.0 ns | 1,476,241.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |  1,040.1 ns |    397.4 ns |    21.78 ns |  12.58 ns |  1,025.4 ns |  1,065.1 ns |   961,465.8 |  1.54 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 |  3,100.8 ns |    866.0 ns |    47.47 ns |  27.41 ns |  3,057.2 ns |  3,151.4 ns |   322,493.5 |  4.58 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 |  3,319.0 ns |  2,905.8 ns |   159.28 ns |  91.96 ns |  3,217.3 ns |  3,502.5 ns |   301,297.6 |  4.90 |  6.3667 |      - |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 |  6,659.0 ns |  3,629.0 ns |   198.92 ns | 114.85 ns |  6,540.5 ns |  6,888.6 ns |   150,173.6 |  9.83 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 12,494.7 ns |  6,104.9 ns |   334.63 ns | 193.20 ns | 12,182.3 ns | 12,847.8 ns |    80,034.1 | 18.47 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
