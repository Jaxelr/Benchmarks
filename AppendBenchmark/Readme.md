# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |        Error |    StdDev |    StdErr |        Min |        Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|-------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   204.6 ns |     35.96 ns |   1.97 ns |   1.14 ns |   203.2 ns |   206.9 ns | 4,887,154.0 |  0.39 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   312.2 ns |    114.65 ns |   6.28 ns |   3.63 ns |   307.8 ns |   319.4 ns | 3,203,149.9 |  0.60 |  0.6652 | 0.0100 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   518.9 ns |     24.78 ns |   1.36 ns |   0.78 ns |   517.7 ns |   520.4 ns | 1,927,189.9 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   898.0 ns |  1,768.15 ns |  96.92 ns |  55.96 ns |   840.8 ns | 1,009.9 ns | 1,113,622.2 |  1.73 |  2.5654 | 0.1221 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 | 2,110.9 ns |    287.08 ns |  15.74 ns |   9.09 ns | 2,100.1 ns | 2,129.0 ns |   473,725.7 |  4.07 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 | 2,251.9 ns |    296.56 ns |  16.26 ns |   9.39 ns | 2,241.8 ns | 2,270.6 ns |   444,072.6 |  4.34 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 | 4,836.7 ns |    883.74 ns |  48.44 ns |  27.97 ns | 4,800.8 ns | 4,891.8 ns |   206,753.1 |  9.32 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 8,039.7 ns |  2,324.82 ns | 127.43 ns |  73.57 ns | 7,922.3 ns | 8,175.2 ns |   124,382.4 | 15.49 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
|              |              |       |            |              |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   210.1 ns |     78.69 ns |   4.31 ns |   2.49 ns |   205.6 ns |   214.3 ns | 4,760,248.0 |  0.41 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   283.4 ns |     33.73 ns |   1.85 ns |   1.07 ns |   281.3 ns |   284.5 ns | 3,528,368.6 |  0.55 |  0.6652 | 0.0100 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   517.0 ns |     41.62 ns |   2.28 ns |   1.32 ns |   515.1 ns |   519.5 ns | 1,934,127.6 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |   794.2 ns |     14.44 ns |   0.79 ns |   0.46 ns |   793.3 ns |   794.9 ns | 1,259,200.0 |  1.54 |  2.5654 | 0.1221 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] |   101 | 2,256.2 ns |    258.46 ns |  14.17 ns |   8.18 ns | 2,242.3 ns | 2,270.7 ns |   443,214.8 |  4.36 |  6.3667 | 0.7935 |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] |   101 | 2,388.4 ns |  1,573.58 ns |  86.25 ns |  49.80 ns | 2,329.3 ns | 2,487.4 ns |   418,681.9 |  4.62 |  6.3286 | 0.7896 |  39.09 KB |        9.93 |
|       Append | Int32[10000] |   101 | 5,386.5 ns | 10,730.34 ns | 588.17 ns | 339.58 ns | 4,949.2 ns | 6,055.2 ns |   185,648.5 | 10.42 |  6.3248 | 0.7858 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 8,010.8 ns |  1,176.24 ns |  64.47 ns |  37.22 ns | 7,937.1 ns | 8,056.8 ns |   124,832.0 | 15.49 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
