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
| Method       | array        | value | Mean       | Error       | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendConcat | Int32[1000]  | 4     |   159.3 ns |    82.50 ns |  4.52 ns |  2.61 ns |   155.4 ns |   164.3 ns | 6,276,341.6 |  0.35 |  0.9842 |      - |   4.02 KB |        1.02 |
| AppendCopyTo | Int32[1000]  | 4     |   198.2 ns |   106.84 ns |  5.86 ns |  3.38 ns |   193.3 ns |   204.7 ns | 5,045,575.1 |  0.44 |  0.9632 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 4     |   452.9 ns |   135.22 ns |  7.41 ns |  4.28 ns |   444.5 ns |   458.5 ns | 2,208,143.4 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   532.7 ns |   156.08 ns |  8.56 ns |  4.94 ns |   524.4 ns |   541.5 ns | 1,877,116.9 |  1.18 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,148.5 ns |   117.50 ns |  6.44 ns |  3.72 ns | 1,144.4 ns | 1,155.9 ns |   870,702.4 |  2.54 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,176.1 ns |   180.41 ns |  9.89 ns |  5.71 ns | 1,167.5 ns | 1,186.9 ns |   850,289.0 |  2.60 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,513.8 ns |   197.73 ns | 10.84 ns |  6.26 ns | 3,501.3 ns | 3,520.6 ns |   284,592.5 |  7.76 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,175.1 ns | 1,738.73 ns | 95.31 ns | 55.02 ns | 4,100.3 ns | 4,282.4 ns |   239,517.3 |  9.22 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
|              |              |       |            |             |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   141.3 ns |    26.39 ns |  1.45 ns |  0.84 ns |   139.7 ns |   142.5 ns | 7,078,296.4 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   153.3 ns |    19.51 ns |  1.07 ns |  0.62 ns |   152.3 ns |   154.4 ns | 6,524,676.3 |  0.35 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   436.1 ns |    62.88 ns |  3.45 ns |  1.99 ns |   433.9 ns |   440.0 ns | 2,293,247.4 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   499.0 ns |   117.52 ns |  6.44 ns |  3.72 ns |   491.7 ns |   503.8 ns | 2,003,979.4 |  1.14 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,147.9 ns |   128.24 ns |  7.03 ns |  4.06 ns | 1,141.3 ns | 1,155.3 ns |   871,166.6 |  2.63 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,170.6 ns |    85.59 ns |  4.69 ns |  2.71 ns | 1,165.9 ns | 1,175.3 ns |   854,256.3 |  2.68 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,733.3 ns |   569.93 ns | 31.24 ns | 18.04 ns | 3,697.6 ns | 3,755.3 ns |   267,857.2 |  8.56 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,921.3 ns | 1,066.28 ns | 58.45 ns | 33.74 ns | 3,854.8 ns | 3,964.5 ns |   255,017.3 |  8.99 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
