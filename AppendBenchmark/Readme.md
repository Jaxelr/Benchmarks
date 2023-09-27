# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |       Error |    StdDev |    StdErr |        Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   205.6 ns |   129.42 ns |   7.09 ns |   4.10 ns |   200.2 ns |    213.6 ns | 4,864,983.2 |  0.38 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   274.4 ns |   170.67 ns |   9.36 ns |   5.40 ns |   268.4 ns |    285.2 ns | 3,644,401.7 |  0.51 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   537.6 ns |    33.96 ns |   1.86 ns |   1.07 ns |   535.5 ns |    539.0 ns | 1,860,066.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   787.5 ns |   316.59 ns |  17.35 ns |  10.02 ns |   773.0 ns |    806.7 ns | 1,269,794.1 |  1.46 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 | 2,697.2 ns | 3,727.92 ns | 204.34 ns | 117.98 ns | 2,507.1 ns |  2,913.2 ns |   370,760.4 |  5.02 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 | 2,709.7 ns | 2,177.75 ns | 119.37 ns |  68.92 ns | 2,615.5 ns |  2,844.0 ns |   369,042.5 |  5.04 |  6.3667 |      - |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 | 5,918.1 ns | 8,140.01 ns | 446.18 ns | 257.60 ns | 5,650.8 ns |  6,433.2 ns |   168,973.9 | 11.01 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 8,636.4 ns | 2,367.43 ns | 129.77 ns |  74.92 ns | 8,548.4 ns |  8,785.5 ns |   115,788.6 | 16.06 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |             |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   236.3 ns |    51.78 ns |   2.84 ns |   1.64 ns |   233.1 ns |    238.5 ns | 4,231,812.1 |  0.41 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   345.7 ns |    27.50 ns |   1.51 ns |   0.87 ns |   344.1 ns |    347.1 ns | 2,892,974.5 |  0.60 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   580.3 ns |   236.72 ns |  12.98 ns |   7.49 ns |   566.0 ns |    591.3 ns | 1,723,307.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |   884.7 ns |   613.68 ns |  33.64 ns |  19.42 ns |   847.2 ns |    912.1 ns | 1,130,270.7 |  1.52 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] |   101 | 2,707.1 ns |   709.44 ns |  38.89 ns |  22.45 ns | 2,669.8 ns |  2,747.4 ns |   369,405.3 |  4.67 |  6.3667 |      - |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] |   101 | 3,120.6 ns | 9,215.94 ns | 505.16 ns | 291.65 ns | 2,560.1 ns |  3,540.7 ns |   320,448.5 |  5.39 |  6.3286 |      - |  39.09 KB |        9.93 |
|       Append | Int32[10000] |   101 | 5,002.8 ns |   348.44 ns |  19.10 ns |  11.03 ns | 4,988.3 ns |  5,024.4 ns |   199,888.3 |  8.62 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 9,637.1 ns | 6,619.42 ns | 362.83 ns | 209.48 ns | 9,383.1 ns | 10,052.7 ns |   103,765.5 | 16.61 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
