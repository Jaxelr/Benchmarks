# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |        Mean |       Error |      StdDev |      StdErr |         Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|------------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |    543.0 ns |  1,838.3 ns |   100.76 ns |    58.17 ns |    447.4 ns |    648.2 ns | 1,841,665.9 |  0.55 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |    697.0 ns |  1,099.7 ns |    60.28 ns |    34.80 ns |    627.4 ns |    732.1 ns | 1,434,702.0 |  0.70 |  0.6647 | 0.0095 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |    996.1 ns |    320.6 ns |    17.57 ns |    10.15 ns |    975.8 ns |  1,007.3 ns | 1,003,932.9 |  1.00 |  0.6409 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |  1,960.7 ns |  1,799.4 ns |    98.63 ns |    56.95 ns |  1,876.8 ns |  2,069.3 ns |   510,021.3 |  1.97 |  2.5654 | 0.1221 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] |     4 |  4,382.1 ns |  8,240.2 ns |   451.68 ns |   260.78 ns |  3,963.2 ns |  4,860.7 ns |   228,198.7 |  4.40 |  6.3629 | 0.7935 |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] |     4 |  4,391.1 ns | 15,914.4 ns |   872.32 ns |   503.63 ns |  3,844.3 ns |  5,397.1 ns |   227,735.3 |  4.41 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
|       Append | Int32[10000] |     4 |  8,358.6 ns |  4,072.4 ns |   223.22 ns |   128.88 ns |  8,178.4 ns |  8,608.3 ns |   119,637.9 |  8.39 |  6.3171 | 0.7782 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 23,691.5 ns | 30,804.6 ns | 1,688.50 ns |   974.86 ns | 22,366.9 ns | 25,592.8 ns |    42,209.2 | 23.78 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
|              |              |       |             |             |             |             |             |             |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |    684.3 ns |  1,993.6 ns |   109.28 ns |    63.09 ns |    563.5 ns |    776.2 ns | 1,461,368.0 |  0.42 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |  1,075.5 ns |  3,203.2 ns |   175.58 ns |   101.37 ns |    878.7 ns |  1,216.0 ns |   929,810.3 |  0.67 |  0.6647 | 0.0095 |   4.08 KB |        1.04 |
| AppendToList |  Int32[1000] |   101 |  1,590.6 ns |  1,625.4 ns |    89.09 ns |    51.44 ns |  1,513.1 ns |  1,687.9 ns |   628,689.2 |  0.98 |  2.5635 | 0.1183 |  15.73 KB |        4.00 |
|       Append |  Int32[1000] |   101 |  1,656.1 ns |  4,251.1 ns |   233.02 ns |   134.53 ns |  1,416.1 ns |  1,881.4 ns |   603,836.9 |  1.00 |  0.6409 | 0.0095 |   3.94 KB |        1.00 |
| AppendCopyTo | Int32[10000] |   101 |  7,078.8 ns | 42,957.1 ns | 2,354.63 ns | 1,359.44 ns |  5,063.3 ns |  9,666.9 ns |   141,266.0 |  4.20 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
|       Append | Int32[10000] |   101 |  8,922.5 ns |  3,411.2 ns |   186.98 ns |   107.95 ns |  8,716.8 ns |  9,082.2 ns |   112,076.0 |  5.47 |  6.3171 | 0.7782 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 11,477.8 ns |  1,438.9 ns |    78.87 ns |    45.53 ns | 11,393.0 ns | 11,548.9 ns |    87,124.8 |  7.03 |  6.3629 | 0.7935 |  39.23 KB |        9.96 |
| AppendToList | Int32[10000] |   101 | 42,702.4 ns | 32,659.8 ns | 1,790.20 ns | 1,033.57 ns | 41,030.1 ns | 44,590.8 ns |    23,417.9 | 26.21 | 25.3906 | 8.4229 | 156.36 KB |       39.71 |
