# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   178.0 ns |   151.08 ns |   8.28 ns |   4.78 ns |   172.3 ns |   187.5 ns | 5,619,207.0 |  0.31 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   196.1 ns |    15.45 ns |   0.85 ns |   0.49 ns |   195.3 ns |   197.0 ns | 5,099,857.3 |  0.34 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   578.6 ns |   345.19 ns |  18.92 ns |  10.92 ns |   557.2 ns |   593.2 ns | 1,728,257.5 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   658.0 ns |   225.58 ns |  12.36 ns |   7.14 ns |   644.8 ns |   669.3 ns | 1,519,799.5 |  1.14 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,149.9 ns |   789.55 ns |  43.28 ns |  24.99 ns | 2,103.1 ns | 2,188.5 ns |   465,129.9 |  3.72 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,351.2 ns |   630.32 ns |  34.55 ns |  19.95 ns | 2,312.3 ns | 2,378.5 ns |   425,320.6 |  4.07 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 5,507.4 ns | 3,108.26 ns | 170.37 ns |  98.37 ns | 5,315.4 ns | 5,640.7 ns |   181,574.0 |  9.53 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,191.6 ns | 1,629.99 ns |  89.35 ns |  51.58 ns | 8,089.8 ns | 8,257.2 ns |   122,076.7 | 14.17 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   176.7 ns |   163.30 ns |   8.95 ns |   5.17 ns |   168.9 ns |   186.5 ns | 5,660,373.1 |  0.37 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   204.2 ns |    98.76 ns |   5.41 ns |   3.13 ns |   200.3 ns |   210.4 ns | 4,898,250.5 |  0.42 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   481.4 ns |    67.90 ns |   3.72 ns |   2.15 ns |   478.1 ns |   485.5 ns | 2,077,210.4 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   758.3 ns |   931.81 ns |  51.08 ns |  29.49 ns |   707.6 ns |   809.7 ns | 1,318,654.0 |  1.58 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,068.1 ns |   256.46 ns |  14.06 ns |   8.12 ns | 2,058.9 ns | 2,084.3 ns |   483,531.8 |  4.30 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,190.2 ns |   429.70 ns |  23.55 ns |  13.60 ns | 2,165.4 ns | 2,212.3 ns |   456,576.7 |  4.55 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,814.9 ns |   987.95 ns |  54.15 ns |  31.27 ns | 4,774.8 ns | 4,876.5 ns |   207,689.2 | 10.00 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 7,994.9 ns | 3,399.39 ns | 186.33 ns | 107.58 ns | 7,805.2 ns | 8,177.7 ns |   125,080.2 | 16.61 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
