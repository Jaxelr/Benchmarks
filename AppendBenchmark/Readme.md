# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   174.9 ns |    19.56 ns |   1.07 ns |   0.62 ns |   173.7 ns |   175.7 ns | 5,716,848.2 |  0.36 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   232.9 ns |    16.89 ns |   0.93 ns |   0.53 ns |   232.2 ns |   233.9 ns | 4,294,045.2 |  0.48 |  0.6657 | 0.0002 |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |   486.4 ns |   166.68 ns |   9.14 ns |   5.27 ns |   478.7 ns |   496.5 ns | 2,055,965.4 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   671.4 ns |   206.93 ns |  11.34 ns |   6.55 ns |   660.6 ns |   683.2 ns | 1,489,423.5 |  1.38 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,117.5 ns |    62.46 ns |   3.42 ns |   1.98 ns | 2,115.5 ns | 2,121.5 ns |   472,247.6 |  4.35 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,259.6 ns |   224.07 ns |  12.28 ns |   7.09 ns | 2,251.2 ns | 2,273.7 ns |   442,547.0 |  4.65 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     | 5,108.9 ns | 2,253.17 ns | 123.50 ns |  71.30 ns | 4,998.3 ns | 5,242.1 ns |   195,738.7 | 10.51 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,214.0 ns | 1,732.86 ns |  94.98 ns |  54.84 ns | 8,107.9 ns | 8,291.2 ns |   121,743.6 | 16.89 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   253.9 ns |   440.41 ns |  24.14 ns |  13.94 ns |   226.6 ns |   272.6 ns | 3,938,961.3 |  0.41 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   284.9 ns |   325.54 ns |  17.84 ns |  10.30 ns |   271.5 ns |   305.1 ns | 3,510,469.9 |  0.46 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |   627.3 ns | 1,266.91 ns |  69.44 ns |  40.09 ns |   547.1 ns |   668.4 ns | 1,594,174.0 |  1.01 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   675.6 ns |   208.22 ns |  11.41 ns |   6.59 ns |   662.7 ns |   684.2 ns | 1,480,078.5 |  1.09 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,078.0 ns |   601.65 ns |  32.98 ns |  19.04 ns | 2,050.0 ns | 2,114.3 ns |   481,237.0 |  3.34 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,273.9 ns |   564.58 ns |  30.95 ns |  17.87 ns | 2,244.8 ns | 2,306.4 ns |   439,767.0 |  3.66 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   | 4,771.5 ns |   506.68 ns |  27.77 ns |  16.03 ns | 4,740.5 ns | 4,794.0 ns |   209,578.5 |  7.67 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,258.8 ns | 5,342.59 ns | 292.85 ns | 169.07 ns | 8,089.5 ns | 8,597.0 ns |   121,082.9 | 13.28 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
