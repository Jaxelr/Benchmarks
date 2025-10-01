# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6584)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   128.6 ns |     3.63 ns |   0.20 ns |   0.11 ns |   128.4 ns |   128.8 ns | 7,777,029.2 |  0.37 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   168.0 ns |    42.80 ns |   2.35 ns |   1.35 ns |   166.5 ns |   170.7 ns | 5,951,169.6 |  0.49 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   344.1 ns |    29.90 ns |   1.64 ns |   0.95 ns |   342.2 ns |   345.4 ns | 2,906,424.2 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   519.3 ns |   228.30 ns |  12.51 ns |   7.22 ns |   506.4 ns |   531.4 ns | 1,925,636.3 |  1.51 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,005.4 ns |   431.77 ns |  23.67 ns |  13.66 ns |   989.9 ns | 1,032.6 ns |   994,651.8 |  2.92 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,034.7 ns |    16.06 ns |   0.88 ns |   0.51 ns | 1,034.0 ns | 1,035.7 ns |   966,434.0 |  3.01 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,455.8 ns | 3,971.91 ns | 217.71 ns | 125.70 ns | 3,211.6 ns | 3,629.5 ns |   289,366.9 | 10.04 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,841.8 ns | 7,356.76 ns | 403.25 ns | 232.82 ns | 3,605.9 ns | 4,307.4 ns |   260,297.4 | 11.17 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   133.0 ns |     8.02 ns |   0.44 ns |   0.25 ns |   132.7 ns |   133.5 ns | 7,520,907.4 |  0.36 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   157.8 ns |    67.26 ns |   3.69 ns |   2.13 ns |   155.4 ns |   162.0 ns | 6,337,958.2 |  0.43 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   365.9 ns |   122.07 ns |   6.69 ns |   3.86 ns |   361.8 ns |   373.7 ns | 2,732,655.4 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   499.3 ns |   205.15 ns |  11.25 ns |   6.49 ns |   490.6 ns |   512.0 ns | 2,002,643.5 |  1.36 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,267.6 ns |   345.57 ns |  18.94 ns |  10.94 ns | 1,249.6 ns | 1,287.4 ns |   788,917.2 |  3.46 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,606.6 ns | 1,462.53 ns |  80.17 ns |  46.28 ns | 1,516.5 ns | 1,670.0 ns |   622,415.3 |  4.39 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,223.1 ns | 1,472.64 ns |  80.72 ns |  46.60 ns | 3,140.3 ns | 3,301.6 ns |   310,263.2 |  8.81 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,768.4 ns | 1,581.71 ns |  86.70 ns |  50.06 ns | 3,714.6 ns | 3,868.5 ns |   265,361.8 | 10.30 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
