# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.200
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   147.9 ns |    96.73 ns |   5.30 ns |   3.06 ns |   143.8 ns |   153.9 ns | 6,762,570.5 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   151.8 ns |    23.62 ns |   1.29 ns |   0.75 ns |   150.8 ns |   153.3 ns | 6,586,220.3 |  0.35 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   436.4 ns |    68.81 ns |   3.77 ns |   2.18 ns |   433.7 ns |   440.7 ns | 2,291,373.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   582.4 ns |   194.93 ns |  10.68 ns |   6.17 ns |   572.3 ns |   593.6 ns | 1,716,984.6 |  1.33 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,312.2 ns | 1,124.71 ns |  61.65 ns |  35.59 ns | 1,245.8 ns | 1,367.6 ns |   762,100.2 |  3.01 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,506.3 ns |   851.08 ns |  46.65 ns |  26.93 ns | 1,472.9 ns | 1,559.6 ns |   663,869.1 |  3.45 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 3,785.5 ns |   605.24 ns |  33.18 ns |  19.15 ns | 3,754.6 ns | 3,820.5 ns |   264,162.5 |  8.67 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,176.8 ns | 1,215.02 ns |  66.60 ns |  38.45 ns | 4,103.5 ns | 4,233.7 ns |   239,416.1 |  9.57 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendConcat | Int32[1000]  | 101   |   152.6 ns |    36.40 ns |   2.00 ns |   1.15 ns |   151.2 ns |   154.9 ns | 6,552,960.1 |  0.31 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendCopyTo | Int32[1000]  | 101   |   178.0 ns |   216.66 ns |  11.88 ns |   6.86 ns |   167.2 ns |   190.7 ns | 5,618,339.6 |  0.36 |  0.9632 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 101   |   501.4 ns | 1,106.93 ns |  60.67 ns |  35.03 ns |   438.6 ns |   559.7 ns | 1,994,321.1 |  1.01 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   518.3 ns |   237.27 ns |  13.01 ns |   7.51 ns |   508.0 ns |   532.9 ns | 1,929,370.9 |  1.04 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,167.3 ns | 1,580.07 ns |  86.61 ns |  50.00 ns | 1,093.8 ns | 1,262.8 ns |   856,706.7 |  2.35 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,184.3 ns |    91.52 ns |   5.02 ns |   2.90 ns | 1,178.9 ns | 1,188.9 ns |   844,402.8 |  2.39 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,699.6 ns | 5,817.86 ns | 318.90 ns | 184.12 ns | 3,490.8 ns | 4,066.7 ns |   270,301.0 |  7.45 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 5,103.4 ns | 8,830.83 ns | 484.05 ns | 279.46 ns | 4,544.5 ns | 5,389.3 ns |   195,947.1 | 10.28 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
