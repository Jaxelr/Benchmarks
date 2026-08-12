# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.303
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   158.1 ns |    38.73 ns |   2.12 ns |   1.23 ns |   155.8 ns |   160.0 ns | 6,325,581.2 |  0.33 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   197.8 ns |    63.75 ns |   3.49 ns |   2.02 ns |   194.5 ns |   201.4 ns | 5,056,449.3 |  0.41 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   485.8 ns |    44.43 ns |   2.44 ns |   1.41 ns |   483.0 ns |   487.4 ns | 2,058,527.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   677.4 ns |   197.22 ns |  10.81 ns |   6.24 ns |   668.0 ns |   689.2 ns | 1,476,201.6 |  1.39 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,346.0 ns |   463.65 ns |  25.41 ns |  14.67 ns | 1,316.6 ns | 1,361.1 ns |   742,956.2 |  2.77 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,398.7 ns |   839.20 ns |  46.00 ns |  26.56 ns | 1,352.2 ns | 1,444.2 ns |   714,931.0 |  2.88 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 3,989.8 ns | 5,456.76 ns | 299.10 ns | 172.69 ns | 3,744.9 ns | 4,323.1 ns |   250,641.8 |  8.21 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,637.4 ns | 4,579.28 ns | 251.01 ns | 144.92 ns | 4,370.7 ns | 4,868.9 ns |   215,636.5 |  9.55 | 37.9715 | 2.1591 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   178.2 ns |    23.09 ns |   1.27 ns |   0.73 ns |   176.9 ns |   179.4 ns | 5,612,423.7 |  0.30 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   216.3 ns |   690.93 ns |  37.87 ns |  21.87 ns |   179.5 ns |   255.2 ns | 4,623,126.4 |  0.37 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendToList | Int32[1000]  | 101   |   557.3 ns |   502.05 ns |  27.52 ns |  15.89 ns |   532.6 ns |   587.0 ns | 1,794,293.7 |  0.95 |  3.8452 |      - |  15.73 KB |        4.00 |
| Append       | Int32[1000]  | 101   |   586.8 ns |   769.99 ns |  42.21 ns |  24.37 ns |   540.3 ns |   622.6 ns | 1,704,276.0 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,877.6 ns | 8,173.44 ns | 448.01 ns | 258.66 ns | 1,601.9 ns | 2,394.6 ns |   532,585.7 |  3.21 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,960.8 ns | 7,280.77 ns | 399.08 ns | 230.41 ns | 1,656.7 ns | 2,412.7 ns |   510,007.5 |  3.35 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,557.1 ns | 1,215.81 ns |  66.64 ns |  38.48 ns | 4,481.6 ns | 4,607.8 ns |   219,437.8 |  7.79 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 5,634.9 ns | 4,916.11 ns | 269.47 ns | 155.58 ns | 5,325.6 ns | 5,819.2 ns |   177,466.9 |  9.64 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
