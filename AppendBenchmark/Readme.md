# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   145.2 ns |    30.11 ns |  1.65 ns |  0.95 ns |   143.3 ns |   146.5 ns | 6,887,412.1 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   165.7 ns |    18.22 ns |  1.00 ns |  0.58 ns |   164.7 ns |   166.7 ns | 6,034,856.3 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   430.8 ns |    62.44 ns |  3.42 ns |  1.98 ns |   427.0 ns |   433.8 ns | 2,321,422.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   509.9 ns |    62.63 ns |  3.43 ns |  1.98 ns |   506.0 ns |   512.3 ns | 1,960,990.1 |  1.18 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   940.2 ns |   177.15 ns |  9.71 ns |  5.61 ns |   933.0 ns |   951.3 ns | 1,063,558.8 |  2.18 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,277.0 ns |   377.77 ns | 20.71 ns | 11.96 ns | 1,257.6 ns | 1,298.8 ns |   783,080.4 |  2.96 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,179.8 ns | 1,104.32 ns | 60.53 ns | 34.95 ns | 3,130.9 ns | 3,247.5 ns |   314,480.9 |  7.38 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,959.9 ns |   194.81 ns | 10.68 ns |  6.16 ns | 3,951.6 ns | 3,972.0 ns |   252,529.2 |  9.19 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
|              |              |       |            |             |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   141.6 ns |    28.45 ns |  1.56 ns |  0.90 ns |   140.7 ns |   143.4 ns | 7,061,860.1 |  0.32 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   169.5 ns |    11.20 ns |  0.61 ns |  0.35 ns |   169.1 ns |   170.2 ns | 5,900,452.5 |  0.39 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   438.9 ns |    32.50 ns |  1.78 ns |  1.03 ns |   437.0 ns |   440.6 ns | 2,278,355.4 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   511.9 ns |   109.68 ns |  6.01 ns |  3.47 ns |   506.3 ns |   518.3 ns | 1,953,473.1 |  1.17 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,154.2 ns |   146.66 ns |  8.04 ns |  4.64 ns | 1,145.3 ns | 1,161.1 ns |   866,410.5 |  2.63 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,175.5 ns |   383.65 ns | 21.03 ns | 12.14 ns | 1,152.3 ns | 1,193.3 ns |   850,732.7 |  2.68 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,466.8 ns |   394.80 ns | 21.64 ns | 12.49 ns | 3,453.3 ns | 3,491.8 ns |   288,450.4 |  7.90 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,145.7 ns |   880.50 ns | 48.26 ns | 27.86 ns | 4,113.9 ns | 4,201.2 ns |   241,215.4 |  9.45 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
