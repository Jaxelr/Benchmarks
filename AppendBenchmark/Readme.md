# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   142.3 ns |    12.31 ns |  0.67 ns |  0.39 ns |   141.6 ns |   143.0 ns | 7,027,718.8 |  0.35 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   155.8 ns |    36.44 ns |  2.00 ns |  1.15 ns |   153.8 ns |   157.8 ns | 6,420,149.8 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   407.7 ns |    20.32 ns |  1.11 ns |  0.64 ns |   406.4 ns |   408.3 ns | 2,452,827.9 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   499.8 ns |   189.46 ns | 10.38 ns |  6.00 ns |   488.1 ns |   507.7 ns | 2,000,637.0 |  1.23 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,102.1 ns |   400.04 ns | 21.93 ns | 12.66 ns | 1,076.7 ns | 1,115.2 ns |   907,393.3 |  2.70 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,103.0 ns | 1,014.86 ns | 55.63 ns | 32.12 ns | 1,038.9 ns | 1,138.7 ns |   906,620.6 |  2.71 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,467.1 ns |   359.43 ns | 19.70 ns | 11.37 ns | 3,451.4 ns | 3,489.2 ns |   288,427.9 |  8.50 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,032.5 ns |   761.61 ns | 41.75 ns | 24.10 ns | 3,984.7 ns | 4,061.7 ns |   247,984.7 |  9.89 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   140.9 ns |    17.98 ns |  0.99 ns |  0.57 ns |   140.2 ns |   142.0 ns | 7,098,346.7 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   154.2 ns |    29.77 ns |  1.63 ns |  0.94 ns |   153.1 ns |   156.1 ns | 6,485,955.9 |  0.37 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   414.3 ns |    83.59 ns |  4.58 ns |  2.65 ns |   409.6 ns |   418.7 ns | 2,413,910.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   506.2 ns |    65.73 ns |  3.60 ns |  2.08 ns |   503.1 ns |   510.1 ns | 1,975,644.5 |  1.22 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,107.9 ns |   187.94 ns | 10.30 ns |  5.95 ns | 1,096.5 ns | 1,116.5 ns |   902,573.7 |  2.67 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,127.3 ns |   420.90 ns | 23.07 ns | 13.32 ns | 1,103.0 ns | 1,148.8 ns |   887,045.5 |  2.72 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,488.0 ns | 1,027.53 ns | 56.32 ns | 32.52 ns | 3,434.7 ns | 3,546.9 ns |   286,695.9 |  8.42 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,015.7 ns |   898.11 ns | 49.23 ns | 28.42 ns | 3,977.6 ns | 4,071.3 ns |   249,021.3 |  9.69 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
