# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error     | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|----------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendConcat | Int32[1000]  | 4     |   165.7 ns | 154.58 ns |  8.47 ns |  4.89 ns |   160.8 ns |   175.5 ns | 6,035,313.1 |  0.37 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendCopyTo | Int32[1000]  | 4     |   173.0 ns |  23.42 ns |  1.28 ns |  0.74 ns |   171.9 ns |   174.4 ns | 5,780,890.4 |  0.39 |  0.9632 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 4     |   448.2 ns |  25.32 ns |  1.39 ns |  0.80 ns |   447.4 ns |   449.8 ns | 2,231,079.0 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   670.4 ns | 575.58 ns | 31.55 ns | 18.21 ns |   643.4 ns |   705.1 ns | 1,491,572.3 |  1.50 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,099.0 ns | 982.96 ns | 53.88 ns | 31.11 ns | 1,036.7 ns | 1,130.5 ns |   909,950.1 |  2.45 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,163.3 ns | 766.65 ns | 42.02 ns | 24.26 ns | 1,115.8 ns | 1,195.5 ns |   859,618.6 |  2.60 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,466.1 ns | 197.38 ns | 10.82 ns |  6.25 ns | 3,455.8 ns | 3,477.4 ns |   288,509.8 |  7.73 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,054.9 ns | 366.53 ns | 20.09 ns | 11.60 ns | 4,033.2 ns | 4,072.9 ns |   246,616.2 |  9.05 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |           |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   151.8 ns |  14.44 ns |  0.79 ns |  0.46 ns |   150.9 ns |   152.5 ns | 6,587,046.1 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   159.2 ns |  75.24 ns |  4.12 ns |  2.38 ns |   156.1 ns |   163.9 ns | 6,282,301.4 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   442.2 ns | 116.68 ns |  6.40 ns |  3.69 ns |   438.4 ns |   449.6 ns | 2,261,236.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   507.5 ns |  61.80 ns |  3.39 ns |  1.96 ns |   503.9 ns |   510.6 ns | 1,970,255.1 |  1.15 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,126.4 ns | 177.43 ns |  9.73 ns |  5.62 ns | 1,118.1 ns | 1,137.1 ns |   887,787.1 |  2.55 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,163.0 ns | 279.03 ns | 15.29 ns |  8.83 ns | 1,150.0 ns | 1,179.9 ns |   859,833.3 |  2.63 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,504.2 ns | 245.04 ns | 13.43 ns |  7.75 ns | 3,492.5 ns | 3,518.8 ns |   285,374.7 |  7.92 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,041.5 ns | 260.05 ns | 14.25 ns |  8.23 ns | 4,025.0 ns | 4,050.2 ns |   247,433.3 |  9.14 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
