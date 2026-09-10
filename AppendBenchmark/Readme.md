# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9445/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   161.3 ns |    33.68 ns |   1.85 ns |  1.07 ns |   159.2 ns |   162.7 ns | 6,198,998.6 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   164.5 ns |    69.22 ns |   3.79 ns |  2.19 ns |   160.5 ns |   168.1 ns | 6,078,754.9 |  0.33 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   497.6 ns |    51.80 ns |   2.84 ns |  1.64 ns |   495.5 ns |   500.8 ns | 2,009,596.4 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   627.7 ns |    35.63 ns |   1.95 ns |  1.13 ns |   625.8 ns |   629.7 ns | 1,593,035.7 |  1.26 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     | 1,340.4 ns |    89.43 ns |   4.90 ns |  2.83 ns | 1,334.9 ns | 1,344.3 ns |   746,041.9 |  2.69 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 1,407.1 ns | 1,372.34 ns |  75.22 ns | 43.43 ns | 1,360.1 ns | 1,493.8 ns |   710,702.1 |  2.83 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 3,540.6 ns | 1,270.42 ns |  69.64 ns | 40.20 ns | 3,495.8 ns | 3,620.8 ns |   282,436.6 |  7.12 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,694.8 ns | 2,011.26 ns | 110.24 ns | 63.65 ns | 4,568.6 ns | 4,772.5 ns |   213,002.6 |  9.43 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   146.7 ns |    30.28 ns |   1.66 ns |  0.96 ns |   145.5 ns |   148.6 ns | 6,818,021.7 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   186.1 ns |    35.83 ns |   1.96 ns |  1.13 ns |   183.9 ns |   187.6 ns | 5,373,199.8 |  0.41 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   455.9 ns |   448.13 ns |  24.56 ns | 14.18 ns |   439.1 ns |   484.1 ns | 2,193,423.7 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   549.6 ns |    97.39 ns |   5.34 ns |  3.08 ns |   544.7 ns |   555.3 ns | 1,819,561.8 |  1.21 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,156.6 ns |    95.74 ns |   5.25 ns |  3.03 ns | 1,152.1 ns | 1,162.4 ns |   864,577.5 |  2.54 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,267.5 ns | 1,283.12 ns |  70.33 ns | 40.61 ns | 1,186.5 ns | 1,313.7 ns |   788,975.6 |  2.79 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,532.5 ns |   224.13 ns |  12.29 ns |  7.09 ns | 3,519.6 ns | 3,544.0 ns |   283,082.8 |  7.76 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,299.0 ns | 1,884.19 ns | 103.28 ns | 59.63 ns | 4,187.0 ns | 4,390.5 ns |   232,612.5 |  9.45 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
