# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   178.6 ns |    48.23 ns |   2.64 ns |   1.53 ns |   175.6 ns |   180.7 ns | 5,600,095.9 |  0.35 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   224.1 ns |   449.18 ns |  24.62 ns |  14.22 ns |   201.7 ns |   250.5 ns | 4,462,063.5 |  0.44 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   506.1 ns |   219.55 ns |  12.03 ns |   6.95 ns |   495.4 ns |   519.1 ns | 1,975,720.7 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   758.5 ns |   832.33 ns |  45.62 ns |  26.34 ns |   705.8 ns |   785.3 ns | 1,318,439.9 |  1.50 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,142.7 ns |   714.48 ns |  39.16 ns |  22.61 ns | 2,102.3 ns | 2,180.5 ns |   466,691.2 |  4.24 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,253.0 ns |   355.81 ns |  19.50 ns |  11.26 ns | 2,233.0 ns | 2,271.9 ns |   443,845.2 |  4.45 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 5,210.9 ns | 4,214.14 ns | 230.99 ns | 133.36 ns | 4,989.5 ns | 5,450.4 ns |   191,905.1 | 10.30 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,478.4 ns | 6,899.47 ns | 378.18 ns | 218.34 ns | 8,157.1 ns | 8,895.2 ns |   117,946.1 | 16.76 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   183.3 ns |   142.58 ns |   7.82 ns |   4.51 ns |   176.6 ns |   191.9 ns | 5,454,827.4 |  0.37 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   271.2 ns | 1,200.96 ns |  65.83 ns |  38.01 ns |   215.6 ns |   343.9 ns | 3,687,318.2 |  0.55 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   492.1 ns |   116.94 ns |   6.41 ns |   3.70 ns |   485.9 ns |   498.7 ns | 2,032,298.4 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   734.6 ns |   800.41 ns |  43.87 ns |  25.33 ns |   687.2 ns |   773.8 ns | 1,361,334.6 |  1.49 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,157.1 ns | 1,200.29 ns |  65.79 ns |  37.98 ns | 2,081.2 ns | 2,195.3 ns |   463,575.0 |  4.38 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,275.0 ns | 1,105.37 ns |  60.59 ns |  34.98 ns | 2,228.9 ns | 2,343.6 ns |   439,567.7 |  4.62 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,978.8 ns | 1,284.77 ns |  70.42 ns |  40.66 ns | 4,897.7 ns | 5,024.8 ns |   200,850.9 | 10.12 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,270.0 ns | 3,137.49 ns | 171.98 ns |  99.29 ns | 8,083.5 ns | 8,422.2 ns |   120,918.7 | 16.81 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
