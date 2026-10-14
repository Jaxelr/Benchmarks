# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]   : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error        | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|-------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   142.0 ns |     17.03 ns |   0.93 ns |   0.54 ns |   141.3 ns |   143.0 ns | 7,044,320.6 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   155.2 ns |     44.18 ns |   2.42 ns |   1.40 ns |   153.7 ns |   158.0 ns | 6,441,481.3 |  0.35 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   444.7 ns |     70.97 ns |   3.89 ns |   2.25 ns |   441.4 ns |   449.0 ns | 2,248,592.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   530.4 ns |    171.79 ns |   9.42 ns |   5.44 ns |   521.9 ns |   540.5 ns | 1,885,372.2 |  1.19 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,171.2 ns |     46.92 ns |   2.57 ns |   1.48 ns | 1,168.9 ns | 1,174.0 ns |   853,849.8 |  2.63 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,220.7 ns |  2,968.02 ns | 162.69 ns |  93.93 ns | 1,059.2 ns | 1,384.5 ns |   819,173.8 |  2.75 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 3,205.6 ns |  4,166.48 ns | 228.38 ns | 131.85 ns | 3,007.0 ns | 3,455.1 ns |   311,958.0 |  7.21 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,064.8 ns |  2,114.96 ns | 115.93 ns |  66.93 ns | 3,931.8 ns | 4,144.4 ns |   246,014.2 |  9.14 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |              |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   154.1 ns |    283.16 ns |  15.52 ns |   8.96 ns |   142.5 ns |   171.8 ns | 6,487,281.1 |  0.35 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   155.7 ns |     41.77 ns |   2.29 ns |   1.32 ns |   154.2 ns |   158.3 ns | 6,423,373.8 |  0.35 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   439.2 ns |    134.52 ns |   7.37 ns |   4.26 ns |   430.7 ns |   444.2 ns | 2,276,983.2 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   520.2 ns |    149.46 ns |   8.19 ns |   4.73 ns |   514.1 ns |   529.6 ns | 1,922,162.1 |  1.18 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,202.7 ns |    244.71 ns |  13.41 ns |   7.74 ns | 1,193.4 ns | 1,218.1 ns |   831,434.1 |  2.74 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,472.3 ns |  1,020.87 ns |  55.96 ns |  32.31 ns | 1,416.6 ns | 1,528.5 ns |   679,203.9 |  3.35 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 3,695.4 ns |     98.59 ns |   5.40 ns |   3.12 ns | 3,691.0 ns | 3,701.5 ns |   270,603.4 |  8.42 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,550.7 ns | 11,380.87 ns | 623.82 ns | 360.16 ns | 3,877.1 ns | 5,108.4 ns |   219,744.4 | 10.36 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
