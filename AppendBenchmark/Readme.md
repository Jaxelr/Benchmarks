# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error       | StdDev      | StdErr    | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    263.1 ns |    179.8 ns |     9.85 ns |   5.69 ns |    255.7 ns |    274.3 ns | 3,801,011.8 |  0.39 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    349.7 ns |    321.6 ns |    17.63 ns |  10.18 ns |    332.7 ns |    367.9 ns | 2,859,280.8 |  0.52 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |    671.9 ns |    239.0 ns |    13.10 ns |   7.56 ns |    664.3 ns |    687.1 ns | 1,488,209.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |  1,187.2 ns |  2,854.4 ns |   156.46 ns |  90.33 ns |  1,009.7 ns |  1,305.3 ns |   842,329.8 |  1.77 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |  3,162.8 ns |  1,669.1 ns |    91.49 ns |  52.82 ns |  3,081.9 ns |  3,262.1 ns |   316,180.3 |  4.71 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |  3,265.5 ns |    636.2 ns |    34.87 ns |  20.13 ns |  3,225.3 ns |  3,287.0 ns |   306,228.5 |  4.86 |  6.3667 |      - |  39.23 KB |        9.96 |
| AppendToList | Int32[10000] | 4     | 12,809.6 ns | 11,576.7 ns |   634.56 ns | 366.36 ns | 12,419.6 ns | 13,541.8 ns |    78,066.5 | 19.07 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
| Append       | Int32[10000] | 4     | 15,027.1 ns | 23,861.2 ns | 1,307.91 ns | 755.12 ns | 13,936.3 ns | 16,477.1 ns |    66,546.4 | 22.35 |  6.3171 |      - |  39.09 KB |        9.93 |
|              |              |       |             |             |             |           |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    470.4 ns |  2,958.3 ns |   162.16 ns |  93.62 ns |    376.6 ns |    657.7 ns | 2,125,764.3 |  0.67 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    631.9 ns |  3,197.5 ns |   175.27 ns | 101.19 ns |    493.7 ns |    829.0 ns | 1,582,582.6 |  0.90 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |    696.0 ns |    412.3 ns |    22.60 ns |  13.05 ns |    674.7 ns |    719.7 ns | 1,436,758.2 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendCopyTo | Int32[10000] | 101   |  3,616.4 ns |  7,058.4 ns |   386.90 ns | 223.37 ns |  3,171.0 ns |  3,869.4 ns |   276,519.7 |  5.21 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  4,231.2 ns | 10,081.1 ns |   552.58 ns | 319.03 ns |  3,802.7 ns |  4,854.8 ns |   236,341.7 |  6.10 |  6.3667 |      - |  39.23 KB |        9.96 |
| AppendToList | Int32[1000]  | 101   |  4,535.8 ns | 18,453.9 ns | 1,011.52 ns | 584.00 ns |  3,377.9 ns |  5,247.7 ns |   220,467.8 |  6.55 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| Append       | Int32[10000] | 101   | 10,702.8 ns | 14,724.2 ns |   807.08 ns | 465.97 ns |  9,832.8 ns | 11,427.1 ns |    93,433.4 | 15.41 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 13,917.8 ns | 11,113.3 ns |   609.16 ns | 351.70 ns | 13,405.3 ns | 14,591.3 ns |    71,850.4 | 19.99 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
