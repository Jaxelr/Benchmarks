# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error      | StdDev    | StdErr    | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|-----------:|----------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    270.8 ns |   328.1 ns |  17.98 ns |  10.38 ns |    250.0 ns |    281.7 ns | 3,692,910.4 |  0.40 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    330.2 ns |   700.2 ns |  38.38 ns |  22.16 ns |    299.6 ns |    373.3 ns | 3,028,132.2 |  0.49 |  0.6561 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |    681.4 ns | 1,575.6 ns |  86.36 ns |  49.86 ns |    617.0 ns |    779.5 ns | 1,467,566.5 |  1.01 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |  1,205.8 ns | 3,694.4 ns | 202.50 ns | 116.92 ns |  1,046.8 ns |  1,433.8 ns |   829,315.7 |  1.79 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 4     |  2,543.5 ns | 6,698.4 ns | 367.16 ns | 211.98 ns |  2,238.9 ns |  2,951.2 ns |   393,159.3 |  3.77 |  6.3667 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     |  2,859.5 ns | 3,732.1 ns | 204.57 ns | 118.11 ns |  2,626.4 ns |  3,008.9 ns |   349,707.0 |  4.24 |  6.3286 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     |  6,257.7 ns | 3,315.8 ns | 181.75 ns | 104.93 ns |  6,070.5 ns |  6,433.4 ns |   159,803.2 |  9.28 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     |  8,175.4 ns | 2,369.4 ns | 129.87 ns |  74.98 ns |  8,032.9 ns |  8,287.1 ns |   122,318.9 | 12.12 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |             |            |           |           |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    327.5 ns |   126.6 ns |   6.94 ns |   4.01 ns |    322.9 ns |    335.5 ns | 3,053,090.7 |  0.30 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    475.2 ns |   874.1 ns |  47.91 ns |  27.66 ns |    431.0 ns |    526.1 ns | 2,104,505.1 |  0.43 |  0.6561 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |  1,096.8 ns | 1,541.4 ns |  84.49 ns |  48.78 ns |  1,047.8 ns |  1,194.4 ns |   911,736.3 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |  1,114.1 ns | 1,734.7 ns |  95.09 ns |  54.90 ns |  1,036.2 ns |  1,220.0 ns |   897,615.1 |  1.02 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |  3,353.1 ns |   892.4 ns |  48.92 ns |  28.24 ns |  3,310.7 ns |  3,406.6 ns |   298,232.1 |  3.07 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  3,643.6 ns |   209.9 ns |  11.51 ns |   6.64 ns |  3,631.3 ns |  3,654.0 ns |   274,450.9 |  3.33 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   |  7,834.6 ns | 3,348.8 ns | 183.56 ns | 105.98 ns |  7,719.3 ns |  8,046.3 ns |   127,639.3 |  7.17 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 13,476.0 ns | 1,220.7 ns |  66.91 ns |  38.63 ns | 13,426.0 ns | 13,552.0 ns |    74,206.1 | 12.33 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
