# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|------------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendConcat | Int32[1000]  | 4     |    524.1 ns |    562.9 ns |    30.86 ns |    17.81 ns |    494.0 ns |    555.7 ns | 1,907,964.2 |  0.20 |  0.6657 |      - |   4.08 KB |        1.04 |
| AppendCopyTo | Int32[1000]  | 4     |    754.7 ns |  8,221.8 ns |   450.66 ns |   260.19 ns |    433.9 ns |  1,270.0 ns | 1,325,017.5 |  0.29 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |  1,486.3 ns |  3,991.0 ns |   218.76 ns |   126.30 ns |  1,234.0 ns |  1,623.8 ns |   672,830.8 |  0.57 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| Append       | Int32[1000]  | 4     |  2,600.9 ns |  1,972.1 ns |   108.10 ns |    62.41 ns |  2,537.3 ns |  2,725.7 ns |   384,484.6 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[10000] | 4     | 11,608.7 ns |  3,876.0 ns |   212.46 ns |   122.66 ns | 11,363.5 ns | 11,737.7 ns |    86,142.0 |  4.47 |  6.3629 |      - |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] | 4     | 11,742.3 ns |  8,193.6 ns |   449.12 ns |   259.30 ns | 11,283.9 ns | 12,181.5 ns |    85,162.0 |  4.52 |  6.3171 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 19,232.9 ns | 18,891.8 ns | 1,035.52 ns |   597.86 ns | 18,078.7 ns | 20,080.4 ns |    51,994.1 |  7.41 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 44,456.0 ns | 14,529.5 ns |   796.41 ns |   459.81 ns | 43,649.5 ns | 45,241.9 ns |    22,494.2 | 17.11 | 25.3906 | 8.3618 | 156.36 KB |       39.71 |
|              |              |       |             |             |             |             |             |             |             |       |         |        |           |             |
| AppendConcat | Int32[1000]  | 101   |    565.9 ns |  3,000.7 ns |   164.48 ns |    94.96 ns |    447.4 ns |    753.7 ns | 1,766,970.2 |  0.23 |  0.6657 |      - |   4.08 KB |        1.04 |
| AppendCopyTo | Int32[1000]  | 101   |  1,336.1 ns |  1,731.2 ns |    94.89 ns |    54.79 ns |  1,233.5 ns |  1,420.6 ns |   748,457.4 |  0.54 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |  1,980.6 ns |  2,989.0 ns |   163.84 ns |    94.59 ns |  1,840.7 ns |  2,160.9 ns |   504,886.7 |  0.80 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| Append       | Int32[1000]  | 101   |  2,492.5 ns |  2,668.3 ns |   146.26 ns |    84.44 ns |  2,387.5 ns |  2,659.5 ns |   401,211.0 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendCopyTo | Int32[10000] | 101   |  4,135.2 ns |  1,761.8 ns |    96.57 ns |    55.76 ns |  4,026.6 ns |  4,211.6 ns |   241,827.2 |  1.66 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  6,376.4 ns | 38,905.2 ns | 2,132.52 ns | 1,231.21 ns |  5,085.1 ns |  8,837.8 ns |   156,829.4 |  2.58 |  6.3629 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   |  9,462.4 ns |  6,631.3 ns |   363.48 ns |   209.86 ns |  9,093.6 ns |  9,820.3 ns |   105,681.9 |  3.81 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 50,189.4 ns | 58,013.6 ns | 3,179.92 ns | 1,835.93 ns | 48,304.8 ns | 53,860.8 ns |    19,924.5 | 20.13 | 25.3906 | 8.3618 | 156.36 KB |       39.71 |
