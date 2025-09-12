# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   142.2 ns |    96.30 ns |   5.28 ns |   3.05 ns |   136.9 ns |   147.5 ns | 7,032,992.6 |  0.36 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   157.6 ns |    31.73 ns |   1.74 ns |   1.00 ns |   156.1 ns |   159.5 ns | 6,345,238.9 |  0.40 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   398.2 ns |   391.03 ns |  21.43 ns |  12.37 ns |   374.5 ns |   416.3 ns | 2,511,197.1 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   486.8 ns |   186.51 ns |  10.22 ns |   5.90 ns |   477.7 ns |   497.9 ns | 2,054,157.0 |  1.22 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   957.9 ns |   325.68 ns |  17.85 ns |  10.31 ns |   939.4 ns |   975.1 ns | 1,043,942.4 |  2.41 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,016.4 ns |   464.06 ns |  25.44 ns |  14.69 ns |   988.2 ns | 1,037.7 ns |   983,907.7 |  2.56 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,056.5 ns | 2,231.53 ns | 122.32 ns |  70.62 ns | 2,955.8 ns | 3,192.6 ns |   327,172.9 |  7.69 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,919.2 ns | 8,552.43 ns | 468.79 ns | 270.65 ns | 3,514.1 ns | 4,432.7 ns |   255,156.7 |  9.86 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   133.7 ns |    45.37 ns |   2.49 ns |   1.44 ns |   131.0 ns |   136.0 ns | 7,481,960.9 |  0.33 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   162.9 ns |    81.00 ns |   4.44 ns |   2.56 ns |   160.3 ns |   168.0 ns | 6,138,799.7 |  0.40 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   404.1 ns |   309.70 ns |  16.98 ns |   9.80 ns |   385.7 ns |   419.1 ns | 2,474,401.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   508.7 ns |   116.24 ns |   6.37 ns |   3.68 ns |   501.4 ns |   513.3 ns | 1,965,905.5 |  1.26 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] | 101   | 1,109.9 ns |   210.79 ns |  11.55 ns |   6.67 ns | 1,097.3 ns | 1,120.0 ns |   900,980.2 |  2.75 |  9.5234 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 101   | 1,154.2 ns |   511.15 ns |  28.02 ns |  16.18 ns | 1,123.1 ns | 1,177.4 ns |   866,383.9 |  2.86 |  9.5234 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 101   | 3,102.5 ns |   320.17 ns |  17.55 ns |  10.13 ns | 3,083.8 ns | 3,118.5 ns |   322,317.0 |  7.69 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,197.2 ns | 3,331.04 ns | 182.59 ns | 105.42 ns | 4,046.4 ns | 4,400.2 ns |   238,251.8 | 10.40 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
