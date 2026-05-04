# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   126.2 ns |    18.52 ns |   1.01 ns |   0.59 ns |   125.1 ns |   127.2 ns | 7,922,080.9 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   140.9 ns |    12.49 ns |   0.68 ns |   0.40 ns |   140.4 ns |   141.7 ns | 7,098,059.6 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   374.2 ns |   165.27 ns |   9.06 ns |   5.23 ns |   368.6 ns |   384.7 ns | 2,672,242.8 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   518.3 ns |   458.95 ns |  25.16 ns |  14.52 ns |   491.9 ns |   542.0 ns | 1,929,504.7 |  1.39 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,056.3 ns |    62.68 ns |   3.44 ns |   1.98 ns | 1,053.4 ns | 1,060.1 ns |   946,721.8 |  2.82 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,101.3 ns |   745.27 ns |  40.85 ns |  23.59 ns | 1,067.2 ns | 1,146.6 ns |   908,020.0 |  2.94 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 3,303.1 ns | 4,801.76 ns | 263.20 ns | 151.96 ns | 3,063.2 ns | 3,584.6 ns |   302,747.4 |  8.83 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,790.1 ns | 4,145.31 ns | 227.22 ns | 131.18 ns | 3,527.8 ns | 3,926.7 ns |   263,843.5 | 10.13 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   131.6 ns |     9.72 ns |   0.53 ns |   0.31 ns |   131.0 ns |   132.0 ns | 7,596,185.1 |  0.35 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   145.0 ns |    37.12 ns |   2.03 ns |   1.17 ns |   143.8 ns |   147.3 ns | 6,896,820.6 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   376.8 ns |   106.39 ns |   5.83 ns |   3.37 ns |   370.7 ns |   382.4 ns | 2,653,780.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   477.1 ns |    31.87 ns |   1.75 ns |   1.01 ns |   475.2 ns |   478.7 ns | 2,096,126.9 |  1.27 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,054.3 ns |   111.95 ns |   6.14 ns |   3.54 ns | 1,047.4 ns | 1,059.0 ns |   948,478.6 |  2.80 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,081.0 ns |   501.22 ns |  27.47 ns |  15.86 ns | 1,056.2 ns | 1,110.6 ns |   925,048.2 |  2.87 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 3,057.5 ns |   425.18 ns |  23.31 ns |  13.46 ns | 3,033.5 ns | 3,080.1 ns |   327,066.5 |  8.12 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,454.7 ns |    94.31 ns |   5.17 ns |   2.98 ns | 3,449.3 ns | 3,459.6 ns |   289,459.2 |  9.17 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
