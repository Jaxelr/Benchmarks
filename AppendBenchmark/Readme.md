# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |        Error |      StdDev |    StdErr |        Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|-------------:|------------:|----------:|-----------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   185.3 ns |     63.12 ns |     3.46 ns |   2.00 ns |   182.9 ns |    189.3 ns | 5,396,472.5 |  0.36 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   244.2 ns |     55.70 ns |     3.05 ns |   1.76 ns |   241.3 ns |    247.4 ns | 4,095,029.6 |  0.48 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   513.0 ns |    290.56 ns |    15.93 ns |   9.20 ns |   494.6 ns |    522.9 ns | 1,949,405.1 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   742.0 ns |  2,470.83 ns |   135.43 ns |  78.19 ns |   658.3 ns |    898.2 ns | 1,347,734.6 |  1.44 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 | 2,156.4 ns |  1,606.95 ns |    88.08 ns |  50.85 ns | 2,064.1 ns |  2,239.6 ns |   463,731.0 |  4.21 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 | 2,430.8 ns |    662.77 ns |    36.33 ns |  20.97 ns | 2,389.1 ns |  2,455.7 ns |   411,392.1 |  4.74 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 | 5,158.6 ns |    478.20 ns |    26.21 ns |  15.13 ns | 5,128.4 ns |  5,175.5 ns |   193,851.7 | 10.06 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 9,859.1 ns | 22,871.77 ns | 1,253.68 ns | 723.81 ns | 8,461.6 ns | 10,885.0 ns |   101,429.2 | 19.18 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
|              |              |       |            |              |             |           |            |             |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   211.7 ns |    353.22 ns |    19.36 ns |  11.18 ns |   199.7 ns |    234.1 ns | 4,722,965.3 |  0.41 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   274.1 ns |    193.24 ns |    10.59 ns |   6.12 ns |   261.9 ns |    280.9 ns | 3,648,934.1 |  0.53 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   517.2 ns |    435.34 ns |    23.86 ns |  13.78 ns |   497.4 ns |    543.7 ns | 1,933,516.9 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |   713.0 ns |    527.00 ns |    28.89 ns |  16.68 ns |   679.7 ns |    730.6 ns | 1,402,516.2 |  1.38 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 | 2,173.2 ns |  1,121.88 ns |    61.49 ns |  35.50 ns | 2,110.3 ns |  2,233.2 ns |   460,159.0 |  4.21 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 2,345.8 ns |    798.55 ns |    43.77 ns |  25.27 ns | 2,297.2 ns |  2,382.2 ns |   426,296.8 |  4.54 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 | 5,144.1 ns |    565.11 ns |    30.98 ns |  17.88 ns | 5,116.0 ns |  5,177.3 ns |   194,398.4 |  9.96 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 8,533.1 ns |  3,304.62 ns |   181.14 ns | 104.58 ns | 8,324.5 ns |  8,650.8 ns |   117,191.3 | 16.51 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
