# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.202
  [Host]   : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.6 (10.0.6, 10.0.626.17701), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   142.4 ns |     6.35 ns |   0.35 ns |  0.20 ns |   142.2 ns |   142.8 ns | 7,020,476.7 |  0.33 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   166.0 ns |    69.69 ns |   3.82 ns |  2.21 ns |   162.9 ns |   170.3 ns | 6,023,238.8 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   438.0 ns |    40.93 ns |   2.24 ns |  1.30 ns |   435.5 ns |   439.9 ns | 2,283,269.0 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   523.3 ns |   299.91 ns |  16.44 ns |  9.49 ns |   512.5 ns |   542.2 ns | 1,911,098.3 |  1.19 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,131.1 ns |   404.57 ns |  22.18 ns | 12.80 ns | 1,114.7 ns | 1,156.4 ns |   884,064.3 |  2.58 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,160.2 ns |   554.90 ns |  30.42 ns | 17.56 ns | 1,139.1 ns | 1,195.0 ns |   861,946.9 |  2.65 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,163.1 ns | 1,660.72 ns |  91.03 ns | 52.56 ns | 4,090.2 ns | 4,265.1 ns |   240,208.0 |  9.51 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
| Append       | Int32[10000] | 4     | 4,196.5 ns | 3,078.43 ns | 168.74 ns | 97.42 ns | 4,095.7 ns | 4,391.3 ns |   238,296.6 |  9.58 |  9.5215 |      - |  39.09 KB |        9.93 |
|              |              |       |            |             |           |          |            |            |             |       |         |        |           |             |
| AppendConcat | Int32[1000]  | 101   |   167.7 ns |   189.34 ns |  10.38 ns |  5.99 ns |   157.1 ns |   177.9 ns | 5,962,053.2 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendCopyTo | Int32[1000]  | 101   |   198.4 ns |   226.60 ns |  12.42 ns |  7.17 ns |   190.9 ns |   212.8 ns | 5,039,319.6 |  0.45 |  0.9632 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 101   |   443.6 ns |   129.58 ns |   7.10 ns |  4.10 ns |   435.6 ns |   449.1 ns | 2,254,462.5 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   571.8 ns |    70.02 ns |   3.84 ns |  2.22 ns |   567.4 ns |   574.7 ns | 1,748,902.1 |  1.29 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,138.9 ns |   167.60 ns |   9.19 ns |  5.30 ns | 1,133.4 ns | 1,149.5 ns |   878,017.9 |  2.57 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,179.6 ns |   411.27 ns |  22.54 ns | 13.02 ns | 1,154.0 ns | 1,196.8 ns |   847,775.2 |  2.66 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 3,599.3 ns | 1,129.00 ns |  61.88 ns | 35.73 ns | 3,528.4 ns | 3,642.5 ns |   277,833.1 |  8.12 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,186.7 ns | 2,050.85 ns | 112.41 ns | 64.90 ns | 4,114.7 ns | 4,316.3 ns |   238,850.3 |  9.44 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
