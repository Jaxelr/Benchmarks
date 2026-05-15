# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   147.7 ns |    33.42 ns |   1.83 ns |  1.06 ns |   145.6 ns |   149.1 ns | 6,771,125.6 |  0.33 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   162.2 ns |    59.24 ns |   3.25 ns |  1.87 ns |   158.5 ns |   164.4 ns | 6,164,358.9 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   449.2 ns |    48.98 ns |   2.68 ns |  1.55 ns |   446.2 ns |   451.3 ns | 2,226,161.0 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   629.2 ns |   156.98 ns |   8.60 ns |  4.97 ns |   621.4 ns |   638.4 ns | 1,589,243.4 |  1.40 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,175.0 ns |   289.51 ns |  15.87 ns |  9.16 ns | 1,158.4 ns | 1,190.0 ns |   851,055.8 |  2.62 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,237.2 ns |   878.69 ns |  48.16 ns | 27.81 ns | 2,187.2 ns | 2,283.3 ns |   446,996.1 |  4.98 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,659.0 ns | 1,204.44 ns |  66.02 ns | 38.12 ns | 3,616.5 ns | 3,735.1 ns |   273,297.6 |  8.15 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 5,792.4 ns | 3,125.12 ns | 171.30 ns | 98.90 ns | 5,650.4 ns | 5,982.7 ns |   172,638.9 | 12.90 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   158.8 ns |    13.84 ns |   0.76 ns |  0.44 ns |   158.0 ns |   159.4 ns | 6,296,098.1 |  0.36 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   160.2 ns |    59.93 ns |   3.29 ns |  1.90 ns |   156.6 ns |   163.0 ns | 6,241,217.9 |  0.36 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   440.9 ns |    49.33 ns |   2.70 ns |  1.56 ns |   438.1 ns |   443.5 ns | 2,268,014.9 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   536.0 ns |   329.48 ns |  18.06 ns | 10.43 ns |   524.7 ns |   556.8 ns | 1,865,712.9 |  1.22 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,194.2 ns |   359.91 ns |  19.73 ns | 11.39 ns | 1,172.6 ns | 1,211.2 ns |   837,355.7 |  2.71 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,355.4 ns |   888.82 ns |  48.72 ns | 28.13 ns | 1,311.6 ns | 1,407.9 ns |   737,766.9 |  3.07 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 4,073.8 ns | 2,930.40 ns | 160.63 ns | 92.74 ns | 3,893.3 ns | 4,201.1 ns |   245,470.9 |  9.24 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,246.6 ns | 1,585.29 ns |  86.90 ns | 50.17 ns | 4,187.4 ns | 4,346.3 ns |   235,484.8 |  9.63 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
