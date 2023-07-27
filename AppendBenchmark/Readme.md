# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |        Mean |       Error |      StdDev |    StdErr |         Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |    343.5 ns |    163.8 ns |     8.98 ns |   5.19 ns |    336.8 ns |    353.7 ns | 2,911,106.8 |  0.31 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |    971.3 ns |    777.2 ns |    42.60 ns |  24.60 ns |    943.3 ns |  1,020.3 ns | 1,029,600.1 |  0.87 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |  1,177.7 ns |  6,950.9 ns |   381.00 ns | 219.97 ns |    877.0 ns |  1,606.2 ns |   849,120.2 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |  2,884.0 ns |  6,841.2 ns |   374.99 ns | 216.50 ns |  2,607.8 ns |  3,310.9 ns |   346,743.0 |  2.67 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] |     4 |  4,220.5 ns |  2,331.8 ns |   127.81 ns |  73.79 ns |  4,096.9 ns |  4,352.1 ns |   236,937.2 |  3.80 |  6.3629 |      - |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] |     4 |  4,385.0 ns |  1,599.1 ns |    87.65 ns |  50.61 ns |  4,287.6 ns |  4,457.6 ns |   228,052.3 |  3.98 |  6.3248 |      - |  39.09 KB |        9.93 |
|       Append | Int32[10000] |     4 |  9,727.4 ns |  5,810.6 ns |   318.50 ns | 183.88 ns |  9,523.8 ns | 10,094.4 ns |   102,802.8 |  8.81 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 18,812.2 ns | 30,212.0 ns | 1,656.02 ns | 956.10 ns | 17,054.3 ns | 20,342.8 ns |    53,157.1 | 16.89 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
|              |              |       |             |             |             |           |             |             |             |       |         |        |           |             |
| AppendConcat |  Int32[1000] |   101 |  1,240.3 ns |  4,889.8 ns |   268.03 ns | 154.75 ns |    942.8 ns |  1,463.0 ns |   806,239.3 |  0.65 |  0.6657 |      - |   4.08 KB |        1.04 |
| AppendCopyTo |  Int32[1000] |   101 |  1,331.6 ns |  2,908.3 ns |   159.41 ns |  92.04 ns |  1,187.5 ns |  1,502.9 ns |   750,955.4 |  0.69 |  0.6409 |      - |   3.94 KB |        1.00 |
|       Append |  Int32[1000] |   101 |  1,927.4 ns |  2,278.4 ns |   124.89 ns |  72.10 ns |  1,783.2 ns |  2,000.8 ns |   518,829.7 |  1.00 |  0.6409 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |  1,948.3 ns |  4,203.9 ns |   230.43 ns | 133.04 ns |  1,739.4 ns |  2,195.5 ns |   513,279.4 |  1.01 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 |  6,746.1 ns | 10,849.3 ns |   594.69 ns | 343.34 ns |  6,276.2 ns |  7,414.7 ns |   148,234.4 |  3.52 |  6.3248 |      - |  39.09 KB |        9.93 |
|       Append | Int32[10000] |   101 | 10,963.4 ns | 16,886.6 ns |   925.61 ns | 534.40 ns |  9,979.9 ns | 11,817.4 ns |    91,212.2 |  5.71 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 11,698.9 ns |  7,989.1 ns |   437.91 ns | 252.83 ns | 11,227.3 ns | 12,092.6 ns |    85,477.8 |  6.10 |  6.3629 |      - |  39.23 KB |        9.96 |
| AppendToList | Int32[10000] |   101 | 44,553.7 ns | 23,790.2 ns | 1,304.02 ns | 752.88 ns | 43,640.5 ns | 46,047.2 ns |    22,444.8 | 23.16 | 25.3906 | 5.6152 | 156.36 KB |       39.71 |
