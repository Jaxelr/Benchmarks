# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   191.8 ns |   182.29 ns |   9.99 ns |   5.77 ns |   181.0 ns |   200.7 ns | 5,214,574.2 |  0.40 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   225.3 ns |     6.82 ns |   0.37 ns |   0.22 ns |   224.9 ns |   225.5 ns | 4,438,463.1 |  0.47 |  0.6657 | 0.0002 |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |   483.7 ns |   146.89 ns |   8.05 ns |   4.65 ns |   475.7 ns |   491.8 ns | 2,067,186.1 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   653.3 ns |   202.77 ns |  11.11 ns |   6.42 ns |   645.0 ns |   665.9 ns | 1,530,796.0 |  1.35 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,142.3 ns | 1,765.79 ns |  96.79 ns |  55.88 ns | 2,079.3 ns | 2,253.8 ns |   466,782.5 |  4.43 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,171.6 ns |   154.05 ns |   8.44 ns |   4.88 ns | 2,164.2 ns | 2,180.8 ns |   460,490.7 |  4.49 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     | 5,201.6 ns | 4,197.73 ns | 230.09 ns | 132.84 ns | 5,032.2 ns | 5,463.5 ns |   192,250.0 | 10.75 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 7,884.1 ns | 2,868.81 ns | 157.25 ns |  90.79 ns | 7,768.9 ns | 8,063.2 ns |   126,838.0 | 16.30 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   173.1 ns |    17.05 ns |   0.93 ns |   0.54 ns |   172.5 ns |   174.2 ns | 5,777,350.7 |  0.36 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   236.3 ns |   148.94 ns |   8.16 ns |   4.71 ns |   229.8 ns |   245.5 ns | 4,231,593.4 |  0.50 |  0.6657 | 0.0002 |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |   475.8 ns |    30.43 ns |   1.67 ns |   0.96 ns |   474.4 ns |   477.6 ns | 2,101,902.6 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   695.8 ns | 1,154.40 ns |  63.28 ns |  36.53 ns |   647.2 ns |   767.4 ns | 1,437,159.8 |  1.46 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,049.9 ns |   304.81 ns |  16.71 ns |   9.65 ns | 2,034.7 ns | 2,067.8 ns |   487,829.6 |  4.31 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,172.8 ns |   404.18 ns |  22.15 ns |  12.79 ns | 2,159.1 ns | 2,198.4 ns |   460,231.0 |  4.57 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   | 5,110.5 ns |   880.31 ns |  48.25 ns |  27.86 ns | 5,081.5 ns | 5,166.2 ns |   195,676.2 | 10.74 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 7,827.5 ns |   772.90 ns |  42.37 ns |  24.46 ns | 7,779.9 ns | 7,861.0 ns |   127,754.6 | 16.45 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
