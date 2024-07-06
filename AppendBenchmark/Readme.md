# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3810/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error       | StdDev    | StdErr    | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|----------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    204.7 ns |    77.16 ns |   4.23 ns |   2.44 ns |    200.3 ns |    208.7 ns | 4,886,332.1 |  0.34 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    342.8 ns |   322.00 ns |  17.65 ns |  10.19 ns |    322.6 ns |    355.0 ns | 2,917,109.6 |  0.57 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |    603.0 ns |   514.59 ns |  28.21 ns |  16.29 ns |    577.8 ns |    633.5 ns | 1,658,238.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |    989.5 ns |   518.10 ns |  28.40 ns |  16.40 ns |    961.7 ns |  1,018.5 ns | 1,010,619.7 |  1.64 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |  2,208.7 ns | 1,129.73 ns |  61.92 ns |  35.75 ns |  2,158.0 ns |  2,277.7 ns |   452,765.3 |  3.66 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |  2,360.8 ns |   931.68 ns |  51.07 ns |  29.48 ns |  2,318.9 ns |  2,417.7 ns |   423,590.8 |  3.92 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     |  5,505.8 ns | 4,567.85 ns | 250.38 ns | 144.56 ns |  5,222.7 ns |  5,698.2 ns |   181,627.7 |  9.14 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     |  8,613.5 ns | 7,139.53 ns | 391.34 ns | 225.94 ns |  8,269.5 ns |  9,039.3 ns |   116,097.2 | 14.30 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |             |             |           |           |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    279.6 ns |    85.33 ns |   4.68 ns |   2.70 ns |    275.0 ns |    284.4 ns | 3,576,880.1 |  0.38 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    345.9 ns |   309.08 ns |  16.94 ns |   9.78 ns |    334.6 ns |    365.3 ns | 2,891,361.0 |  0.47 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |    747.2 ns |   872.98 ns |  47.85 ns |  27.63 ns |    692.0 ns |    777.9 ns | 1,338,411.1 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |    944.8 ns |   793.06 ns |  43.47 ns |  25.10 ns |    900.7 ns |    987.6 ns | 1,058,428.1 |  1.27 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |  2,869.5 ns | 1,535.15 ns |  84.15 ns |  48.58 ns |  2,772.8 ns |  2,925.8 ns |   348,489.4 |  3.85 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  2,978.6 ns |   183.18 ns |  10.04 ns |   5.80 ns |  2,971.4 ns |  2,990.0 ns |   335,732.9 |  4.00 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   |  6,506.7 ns | 6,101.45 ns | 334.44 ns | 193.09 ns |  6,251.1 ns |  6,885.2 ns |   153,687.4 |  8.75 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 11,758.1 ns | 5,973.29 ns | 327.42 ns | 189.03 ns | 11,380.7 ns | 11,965.4 ns |    85,047.7 | 15.79 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
