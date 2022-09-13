# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |       Error |    StdDev |    StdErr |        Min |        Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   228.6 ns |   108.48 ns |   5.95 ns |   3.43 ns |   224.6 ns |   235.4 ns | 4,375,111.2 |  0.40 |  0.6423 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   310.2 ns |   124.78 ns |   6.84 ns |   3.95 ns |   302.6 ns |   316.0 ns | 3,224,121.4 |  0.54 |  0.6652 | 0.0100 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   571.5 ns |   134.56 ns |   7.38 ns |   4.26 ns |   563.0 ns |   576.2 ns | 1,749,905.6 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   921.2 ns |   591.71 ns |  32.43 ns |  18.73 ns |   883.8 ns |   942.6 ns | 1,085,587.2 |  1.61 |  2.5654 | 0.1221 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 | 2,566.4 ns | 7,522.55 ns | 412.34 ns | 238.06 ns | 2,272.4 ns | 3,037.8 ns |   389,647.4 |  4.49 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 | 2,647.1 ns | 2,029.12 ns | 111.22 ns |  64.21 ns | 2,518.9 ns | 2,718.0 ns |   377,776.7 |  4.63 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 | 5,381.8 ns | 9,979.19 ns | 546.99 ns | 315.81 ns | 5,015.1 ns | 6,010.6 ns |   185,810.2 |  9.43 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 9,106.2 ns | 9,121.03 ns | 499.95 ns | 288.65 ns | 8,606.8 ns | 9,606.7 ns |   109,814.9 | 15.94 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   266.6 ns |    81.85 ns |   4.49 ns |   2.59 ns |   262.2 ns |   271.2 ns | 3,750,922.5 |  0.45 |  0.6423 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   352.8 ns |    86.72 ns |   4.75 ns |   2.74 ns |   349.8 ns |   358.2 ns | 2,834,794.8 |  0.59 |  0.6652 | 0.0100 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   598.7 ns |   282.72 ns |  15.50 ns |   8.95 ns |   580.9 ns |   608.5 ns | 1,670,183.8 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |   988.1 ns |   281.11 ns |  15.41 ns |   8.90 ns |   970.3 ns |   997.4 ns | 1,012,033.6 |  1.65 |  2.5654 | 0.1221 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 | 2,384.1 ns | 1,565.61 ns |  85.82 ns |  49.55 ns | 2,295.4 ns | 2,466.7 ns |   419,447.3 |  3.98 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 2,531.5 ns | 1,744.70 ns |  95.63 ns |  55.21 ns | 2,461.3 ns | 2,640.4 ns |   395,018.6 |  4.23 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 | 5,198.6 ns | 1,415.90 ns |  77.61 ns |  44.81 ns | 5,153.5 ns | 5,288.2 ns |   192,359.2 |  8.69 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 9,153.1 ns | 3,216.23 ns | 176.29 ns | 101.78 ns | 8,950.9 ns | 9,274.7 ns |   109,252.2 | 15.30 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
