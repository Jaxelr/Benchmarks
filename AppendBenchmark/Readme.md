# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |        Mean |       Error |    StdDev |    StdErr |         Min |         Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|----------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |    379.8 ns |    995.3 ns |  54.56 ns |  31.50 ns |    316.9 ns |    414.6 ns | 2,632,936.1 |  0.45 |  0.6423 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |    462.6 ns |    763.0 ns |  41.83 ns |  24.15 ns |    435.1 ns |    510.8 ns | 2,161,491.5 |  0.56 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |    839.2 ns |  1,570.1 ns |  86.06 ns |  49.69 ns |    744.3 ns |    912.2 ns | 1,191,622.9 |  1.00 |  0.6409 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |  1,242.2 ns |    588.6 ns |  32.26 ns |  18.63 ns |  1,212.7 ns |  1,276.7 ns |   805,032.7 |  1.49 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 |  3,921.2 ns |  2,218.1 ns | 121.58 ns |  70.19 ns |  3,840.2 ns |  4,061.0 ns |   255,026.6 |  4.70 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 |  4,189.7 ns |  1,139.8 ns |  62.47 ns |  36.07 ns |  4,124.1 ns |  4,248.5 ns |   238,682.4 |  5.03 |  6.3629 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 |  9,226.1 ns | 16,583.7 ns | 909.01 ns | 524.82 ns |  8,200.9 ns |  9,933.9 ns |   108,388.6 | 11.12 |  6.3171 | 0.7782 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 15,697.2 ns | 16,312.3 ns | 894.13 ns | 516.23 ns | 14,878.1 ns | 16,651.1 ns |    63,705.6 | 18.90 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |             |             |           |           |             |             |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |    395.5 ns |  1,135.6 ns |  62.25 ns |  35.94 ns |    345.8 ns |    465.3 ns | 2,528,358.4 |  0.45 |  0.6423 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |    709.3 ns |  3,291.4 ns | 180.42 ns | 104.16 ns |    561.5 ns |    910.4 ns | 1,409,812.2 |  0.82 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |    874.7 ns |    923.0 ns |  50.59 ns |  29.21 ns |    823.4 ns |    924.6 ns | 1,143,194.5 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |  1,319.9 ns |    758.6 ns |  41.58 ns |  24.01 ns |  1,273.2 ns |  1,353.0 ns |   757,626.8 |  1.51 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 |  3,912.4 ns |  6,540.8 ns | 358.53 ns | 206.99 ns |  3,667.7 ns |  4,323.9 ns |   255,597.1 |  4.48 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 |  4,181.5 ns |  1,044.1 ns |  57.23 ns |  33.04 ns |  4,121.5 ns |  4,235.6 ns |   239,150.9 |  4.79 |  6.3629 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 |  7,964.1 ns |  5,784.0 ns | 317.04 ns | 183.04 ns |  7,664.9 ns |  8,296.4 ns |   125,563.1 |  9.13 |  6.3171 | 0.7782 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 15,404.4 ns | 10,521.1 ns | 576.70 ns | 332.96 ns | 14,758.9 ns | 15,868.8 ns |    64,916.5 | 17.63 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
