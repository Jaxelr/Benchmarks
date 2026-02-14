# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   119.8 ns |    45.28 ns |   2.48 ns |   1.43 ns |   118.2 ns |   122.6 ns | 8,348,357.8 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   134.7 ns |   131.75 ns |   7.22 ns |   4.17 ns |   128.7 ns |   142.7 ns | 7,426,145.0 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   370.3 ns |   248.28 ns |  13.61 ns |   7.86 ns |   360.5 ns |   385.8 ns | 2,700,565.2 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   480.9 ns |   789.63 ns |  43.28 ns |  24.99 ns |   431.2 ns |   510.5 ns | 2,079,496.7 |  1.30 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   944.0 ns |    61.52 ns |   3.37 ns |   1.95 ns |   940.1 ns |   946.1 ns | 1,059,355.3 |  2.55 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |   965.5 ns |    33.85 ns |   1.86 ns |   1.07 ns |   963.9 ns |   967.5 ns | 1,035,770.3 |  2.61 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,030.8 ns |   193.98 ns |  10.63 ns |   6.14 ns | 3,018.8 ns | 3,039.2 ns |   329,946.2 |  8.19 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,241.2 ns |   128.98 ns |   7.07 ns |   4.08 ns | 3,234.2 ns | 3,248.3 ns |   308,524.1 |  8.76 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendConcat | Int32[1000]  | 101   |   154.0 ns |    24.17 ns |   1.32 ns |   0.76 ns |   152.6 ns |   155.3 ns | 6,491,581.2 |  0.43 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendCopyTo | Int32[1000]  | 101   |   163.5 ns |   241.34 ns |  13.23 ns |   7.64 ns |   153.9 ns |   178.6 ns | 6,116,332.9 |  0.46 |  0.9632 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 101   |   357.7 ns |   513.49 ns |  28.15 ns |  16.25 ns |   340.8 ns |   390.2 ns | 2,795,356.2 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   496.8 ns |   180.80 ns |   9.91 ns |   5.72 ns |   487.1 ns |   506.9 ns | 2,012,891.6 |  1.39 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   |   962.8 ns |    84.61 ns |   4.64 ns |   2.68 ns |   959.1 ns |   968.0 ns | 1,038,611.8 |  2.70 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,097.8 ns |   912.74 ns |  50.03 ns |  28.89 ns | 1,040.1 ns | 1,128.3 ns |   910,908.4 |  3.08 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 2,918.5 ns |   116.37 ns |   6.38 ns |   3.68 ns | 2,911.9 ns | 2,924.6 ns |   342,643.9 |  8.19 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,767.8 ns | 7,002.47 ns | 383.83 ns | 221.60 ns | 3,384.4 ns | 4,152.1 ns |   265,403.9 | 10.57 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
