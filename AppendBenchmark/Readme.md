# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.102
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error        | StdDev    | StdErr    | Min        | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|-------------:|----------:|----------:|-----------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   208.1 ns |    183.85 ns |  10.08 ns |   5.82 ns |   202.2 ns |    219.8 ns | 4,804,755.7 |  0.39 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   320.3 ns |    883.64 ns |  48.44 ns |  27.96 ns |   272.3 ns |    369.1 ns | 3,122,554.7 |  0.59 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |   537.3 ns |    773.05 ns |  42.37 ns |  24.46 ns |   488.8 ns |    566.9 ns | 1,861,013.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   693.7 ns |    871.97 ns |  47.80 ns |  27.59 ns |   647.5 ns |    742.9 ns | 1,441,444.1 |  1.30 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,289.2 ns |  2,898.22 ns | 158.86 ns |  91.72 ns | 2,115.3 ns |  2,426.7 ns |   436,834.0 |  4.26 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,305.6 ns |  1,000.53 ns |  54.84 ns |  31.66 ns | 2,247.6 ns |  2,356.6 ns |   433,731.2 |  4.31 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     | 5,078.5 ns |  1,278.14 ns |  70.06 ns |  40.45 ns | 5,000.4 ns |  5,135.9 ns |   196,910.0 |  9.50 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,669.5 ns |  9,508.82 ns | 521.21 ns | 300.92 ns | 8,191.9 ns |  9,225.4 ns |   115,347.5 | 16.16 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |              |           |           |            |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   174.9 ns |     87.68 ns |   4.81 ns |   2.77 ns |   169.6 ns |    178.9 ns | 5,717,629.3 |  0.35 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   240.2 ns |     90.38 ns |   4.95 ns |   2.86 ns |   234.5 ns |    243.8 ns | 4,163,503.9 |  0.48 |  0.6657 | 0.0002 |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |   504.2 ns |    565.83 ns |  31.02 ns |  17.91 ns |   468.6 ns |    525.1 ns | 1,983,231.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   696.7 ns |    225.80 ns |  12.38 ns |   7.15 ns |   686.1 ns |    710.3 ns | 1,435,430.6 |  1.39 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,102.3 ns |    829.88 ns |  45.49 ns |  26.26 ns | 2,049.8 ns |  2,128.7 ns |   475,666.7 |  4.18 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,226.8 ns |    661.61 ns |  36.27 ns |  20.94 ns | 2,195.2 ns |  2,266.4 ns |   449,071.7 |  4.43 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   | 4,981.9 ns |  2,083.37 ns | 114.20 ns |  65.93 ns | 4,871.6 ns |  5,099.6 ns |   200,724.8 |  9.90 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 9,184.9 ns | 13,825.74 ns | 757.84 ns | 437.54 ns | 8,587.5 ns | 10,037.3 ns |   108,874.5 | 18.24 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
