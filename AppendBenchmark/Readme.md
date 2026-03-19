# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   129.1 ns |    25.35 ns |   1.39 ns |   0.80 ns |   127.8 ns |   130.5 ns | 7,747,654.8 |  0.29 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   142.2 ns |    34.37 ns |   1.88 ns |   1.09 ns |   140.6 ns |   144.3 ns | 7,031,387.5 |  0.32 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   448.1 ns |    85.52 ns |   4.69 ns |   2.71 ns |   442.8 ns |   451.8 ns | 2,231,845.3 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   470.1 ns |   180.80 ns |   9.91 ns |   5.72 ns |   463.1 ns |   481.4 ns | 2,127,356.5 |  1.05 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,205.9 ns |   203.15 ns |  11.14 ns |   6.43 ns | 1,193.0 ns | 1,213.0 ns |   829,285.4 |  2.69 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,309.2 ns |   961.52 ns |  52.70 ns |  30.43 ns | 1,256.1 ns | 1,361.5 ns |   763,799.8 |  2.92 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,611.9 ns | 1,398.89 ns |  76.68 ns |  44.27 ns | 3,524.8 ns | 3,669.0 ns |   276,859.4 |  8.06 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 4,133.5 ns | 1,582.47 ns |  86.74 ns |  50.08 ns | 4,038.0 ns | 4,207.3 ns |   241,924.9 |  9.23 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   120.6 ns |    18.32 ns |   1.00 ns |   0.58 ns |   119.8 ns |   121.7 ns | 8,293,159.3 |  0.33 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   137.2 ns |   107.94 ns |   5.92 ns |   3.42 ns |   132.9 ns |   143.9 ns | 7,290,086.3 |  0.37 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   370.0 ns |    18.94 ns |   1.04 ns |   0.60 ns |   368.8 ns |   370.8 ns | 2,703,060.0 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   444.7 ns |   209.41 ns |  11.48 ns |   6.63 ns |   434.4 ns |   457.1 ns | 2,248,485.1 |  1.20 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |   990.1 ns |    69.90 ns |   3.83 ns |   2.21 ns |   987.4 ns |   994.5 ns | 1,010,001.5 |  2.68 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |   996.5 ns |    64.34 ns |   3.53 ns |   2.04 ns |   992.4 ns |   998.8 ns | 1,003,520.5 |  2.69 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,224.8 ns | 4,636.53 ns | 254.14 ns | 146.73 ns | 3,035.1 ns | 3,513.6 ns |   310,097.2 |  8.72 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,346.6 ns |   230.92 ns |  12.66 ns |   7.31 ns | 3,337.5 ns | 3,361.0 ns |   298,812.2 |  9.05 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
