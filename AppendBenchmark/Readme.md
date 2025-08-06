# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   168.7 ns |   196.09 ns |  10.75 ns |   6.21 ns |   161.5 ns |   181.0 ns | 5,928,911.4 |  0.42 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   181.8 ns |     9.86 ns |   0.54 ns |   0.31 ns |   181.4 ns |   182.5 ns | 5,499,313.4 |  0.45 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   405.4 ns |   556.70 ns |  30.51 ns |  17.62 ns |   374.6 ns |   435.6 ns | 2,466,409.8 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   579.7 ns |   111.50 ns |   6.11 ns |   3.53 ns |   574.1 ns |   586.2 ns | 1,724,966.1 |  1.44 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 1,184.8 ns |   241.34 ns |  13.23 ns |   7.64 ns | 1,169.8 ns | 1,194.8 ns |   843,992.0 |  2.93 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,385.6 ns |   657.89 ns |  36.06 ns |  20.82 ns | 1,349.9 ns | 1,422.0 ns |   721,734.1 |  3.43 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 3,398.2 ns | 1,616.86 ns |  88.63 ns |  51.17 ns | 3,300.1 ns | 3,472.5 ns |   294,274.2 |  8.41 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 5,420.2 ns | 5,921.44 ns | 324.57 ns | 187.39 ns | 5,117.2 ns | 5,762.7 ns |   184,495.4 | 13.42 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   157.9 ns |    22.85 ns |   1.25 ns |   0.72 ns |   156.7 ns |   159.2 ns | 6,334,403.3 |  0.43 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   184.0 ns |    28.96 ns |   1.59 ns |   0.92 ns |   182.5 ns |   185.7 ns | 5,435,154.9 |  0.50 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   371.3 ns |    35.01 ns |   1.92 ns |   1.11 ns |   369.9 ns |   373.5 ns | 2,693,226.5 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   588.7 ns |    16.42 ns |   0.90 ns |   0.52 ns |   588.1 ns |   589.7 ns | 1,698,689.5 |  1.59 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,319.9 ns |   366.92 ns |  20.11 ns |  11.61 ns | 1,306.8 ns | 1,343.0 ns |   757,637.4 |  3.55 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,342.0 ns |   155.18 ns |   8.51 ns |   4.91 ns | 1,333.5 ns | 1,350.5 ns |   745,148.8 |  3.61 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,291.5 ns |   269.70 ns |  14.78 ns |   8.53 ns | 3,280.1 ns | 3,308.2 ns |   303,813.5 |  8.86 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,529.3 ns |   626.19 ns |  34.32 ns |  19.82 ns | 4,492.7 ns | 4,560.8 ns |   220,786.2 | 12.20 | 37.9715 | 6.3248 | 156.36 KB |       39.71 |
