# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.0 (10.0.0, 10.0.25.52411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   152.6 ns |    18.54 ns |  1.02 ns |  0.59 ns |   151.7 ns |   153.7 ns | 6,551,681.9 |  0.35 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   161.7 ns |    38.47 ns |  2.11 ns |  1.22 ns |   160.3 ns |   164.1 ns | 6,185,683.3 |  0.37 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   439.6 ns |    28.94 ns |  1.59 ns |  0.92 ns |   438.2 ns |   441.3 ns | 2,274,584.9 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   623.8 ns |   744.63 ns | 40.82 ns | 23.56 ns |   592.3 ns |   669.9 ns | 1,603,119.5 |  1.42 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,020.7 ns |   195.10 ns | 10.69 ns |  6.17 ns | 1,011.4 ns | 1,032.4 ns |   979,688.1 |  2.32 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,068.0 ns |   195.12 ns | 10.70 ns |  6.17 ns | 1,055.6 ns | 1,074.5 ns |   936,358.5 |  2.43 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,198.6 ns | 1,420.76 ns | 77.88 ns | 44.96 ns | 3,109.0 ns | 3,250.0 ns |   312,632.8 |  7.28 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,686.7 ns |   804.84 ns | 44.12 ns | 25.47 ns | 3,636.3 ns | 3,718.3 ns |   271,244.9 |  8.39 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   154.0 ns |   201.57 ns | 11.05 ns |  6.38 ns |   144.0 ns |   165.8 ns | 6,493,556.2 |  0.35 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   156.7 ns |    56.15 ns |  3.08 ns |  1.78 ns |   153.9 ns |   160.0 ns | 6,383,496.4 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   436.4 ns |   416.98 ns | 22.86 ns | 13.20 ns |   417.1 ns |   461.7 ns | 2,291,556.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   543.2 ns |    65.33 ns |  3.58 ns |  2.07 ns |   540.4 ns |   547.2 ns | 1,840,976.7 |  1.25 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,218.4 ns |   256.14 ns | 14.04 ns |  8.11 ns | 1,205.5 ns | 1,233.3 ns |   820,741.5 |  2.80 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,248.4 ns |   272.44 ns | 14.93 ns |  8.62 ns | 1,235.6 ns | 1,264.8 ns |   801,004.8 |  2.87 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 3,670.9 ns | 1,322.57 ns | 72.49 ns | 41.85 ns | 3,623.2 ns | 3,754.4 ns |   272,409.6 |  8.43 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,303.6 ns |   716.28 ns | 39.26 ns | 22.67 ns | 4,268.8 ns | 4,346.2 ns |   232,363.4 |  9.88 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
