# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   137.6 ns |    17.68 ns |   0.97 ns |   0.56 ns |   136.6 ns |   138.5 ns | 7,265,728.4 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   152.4 ns |    21.23 ns |   1.16 ns |   0.67 ns |   151.2 ns |   153.4 ns | 6,560,093.5 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   428.6 ns |    48.98 ns |   2.68 ns |   1.55 ns |   425.7 ns |   431.1 ns | 2,333,387.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   507.1 ns |    43.38 ns |   2.38 ns |   1.37 ns |   504.4 ns |   508.9 ns | 1,972,028.1 |  1.18 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   927.7 ns |   201.84 ns |  11.06 ns |   6.39 ns |   919.3 ns |   940.2 ns | 1,077,936.2 |  2.16 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |   954.9 ns |   127.26 ns |   6.98 ns |   4.03 ns |   947.2 ns |   960.8 ns | 1,047,177.7 |  2.23 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,009.6 ns | 1,759.05 ns |  96.42 ns |  55.67 ns | 2,953.1 ns | 3,120.9 ns |   332,274.7 |  7.02 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,868.1 ns | 7,844.12 ns | 429.96 ns | 248.24 ns | 3,386.5 ns | 4,213.5 ns |   258,526.2 |  9.03 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   137.5 ns |    21.41 ns |   1.17 ns |   0.68 ns |   136.4 ns |   138.7 ns | 7,271,442.5 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   151.8 ns |     6.93 ns |   0.38 ns |   0.22 ns |   151.6 ns |   152.3 ns | 6,585,937.3 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   403.9 ns |    31.80 ns |   1.74 ns |   1.01 ns |   401.9 ns |   405.1 ns | 2,475,586.2 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   522.3 ns |   111.71 ns |   6.12 ns |   3.54 ns |   518.0 ns |   529.3 ns | 1,914,586.8 |  1.29 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,126.2 ns |   221.57 ns |  12.14 ns |   7.01 ns | 1,112.4 ns | 1,135.1 ns |   887,919.8 |  2.79 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,195.4 ns | 2,308.55 ns | 126.54 ns |  73.06 ns | 1,109.0 ns | 1,340.6 ns |   836,546.0 |  2.96 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,447.1 ns |   145.89 ns |   8.00 ns |   4.62 ns | 3,439.1 ns | 3,455.1 ns |   290,094.9 |  8.53 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,968.2 ns |   329.20 ns |  18.04 ns |  10.42 ns | 3,949.2 ns | 3,985.1 ns |   252,001.1 |  9.82 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
