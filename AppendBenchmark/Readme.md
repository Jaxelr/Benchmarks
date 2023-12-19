# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error       | StdDev    | StdErr    | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|----------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    237.5 ns |    31.47 ns |   1.72 ns |   1.00 ns |    236.2 ns |    239.4 ns | 4,211,309.8 |  0.39 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    354.8 ns |   418.78 ns |  22.95 ns |  13.25 ns |    337.4 ns |    380.8 ns | 2,818,673.9 |  0.58 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |    611.5 ns |   331.60 ns |  18.18 ns |  10.49 ns |    599.3 ns |    632.4 ns | 1,635,279.3 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |    861.8 ns |    82.88 ns |   4.54 ns |   2.62 ns |    856.7 ns |    865.4 ns | 1,160,345.2 |  1.41 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |  2,690.7 ns | 1,565.28 ns |  85.80 ns |  49.54 ns |  2,594.1 ns |  2,758.1 ns |   371,647.4 |  4.41 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |  2,967.6 ns |   776.07 ns |  42.54 ns |  24.56 ns |  2,921.7 ns |  3,005.8 ns |   336,978.1 |  4.86 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     |  6,262.2 ns | 9,115.51 ns | 499.65 ns | 288.47 ns |  5,831.7 ns |  6,810.1 ns |   159,689.5 | 10.23 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 11,118.9 ns | 3,077.54 ns | 168.69 ns |  97.39 ns | 10,926.8 ns | 11,242.6 ns |    89,936.6 | 18.20 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |             |             |           |           |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    242.9 ns |    67.55 ns |   3.70 ns |   2.14 ns |    240.2 ns |    247.1 ns | 4,117,136.2 |  0.33 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    336.8 ns |    90.49 ns |   4.96 ns |   2.86 ns |    332.6 ns |    342.2 ns | 2,969,379.9 |  0.46 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |    734.9 ns |   797.20 ns |  43.70 ns |  25.23 ns |    684.4 ns |    760.6 ns | 1,360,731.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |    961.7 ns |   871.16 ns |  47.75 ns |  27.57 ns |    933.6 ns |  1,016.9 ns | 1,039,772.9 |  1.31 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |  3,105.6 ns | 3,865.12 ns | 211.86 ns | 122.32 ns |  2,890.1 ns |  3,313.6 ns |   322,003.7 |  4.24 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  3,196.8 ns | 1,855.04 ns | 101.68 ns |  58.71 ns |  3,126.5 ns |  3,313.4 ns |   312,814.8 |  4.36 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   |  6,295.0 ns | 4,048.43 ns | 221.91 ns | 128.12 ns |  6,039.9 ns |  6,443.9 ns |   158,856.7 |  8.59 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 11,802.0 ns | 3,109.84 ns | 170.46 ns |  98.42 ns | 11,665.2 ns | 11,992.9 ns |    84,731.6 | 16.09 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
