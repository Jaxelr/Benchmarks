# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   179.2 ns |    99.24 ns |   5.44 ns |   3.14 ns |   175.9 ns |   185.5 ns | 5,579,948.4 |  0.31 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   292.4 ns | 1,039.19 ns |  56.96 ns |  32.89 ns |   249.5 ns |   357.0 ns | 3,419,970.2 |  0.51 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   579.2 ns |   614.40 ns |  33.68 ns |  19.44 ns |   547.6 ns |   614.7 ns | 1,726,553.0 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     | 1,314.3 ns | 1,020.86 ns |  55.96 ns |  32.31 ns | 1,251.0 ns | 1,356.9 ns |   760,844.1 |  2.27 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,206.5 ns | 3,655.41 ns | 200.37 ns | 115.68 ns | 2,087.4 ns | 2,437.8 ns |   453,214.3 |  3.82 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,803.7 ns | 2,830.97 ns | 155.17 ns |  89.59 ns | 2,706.1 ns | 2,982.6 ns |   356,670.9 |  4.85 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 5,161.4 ns | 1,622.31 ns |  88.92 ns |  51.34 ns | 5,090.5 ns | 5,261.1 ns |   193,746.8 |  8.93 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 9,936.4 ns |   937.36 ns |  51.38 ns |  29.66 ns | 9,904.6 ns | 9,995.7 ns |   100,640.2 | 17.19 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   316.7 ns |   441.67 ns |  24.21 ns |  13.98 ns |   292.5 ns |   340.9 ns | 3,157,527.5 |  0.43 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   384.5 ns |   600.14 ns |  32.90 ns |  18.99 ns |   361.3 ns |   422.1 ns | 2,600,883.9 |  0.52 |  0.6561 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   743.8 ns | 1,514.37 ns |  83.01 ns |  47.92 ns |   648.2 ns |   797.0 ns | 1,344,400.0 |  1.01 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   | 1,118.3 ns | 1,560.34 ns |  85.53 ns |  49.38 ns | 1,036.5 ns | 1,207.1 ns |   894,236.3 |  1.52 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,437.1 ns | 4,727.33 ns | 259.12 ns | 149.60 ns | 2,172.0 ns | 2,689.7 ns |   410,319.4 |  3.31 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,745.9 ns | 2,911.54 ns | 159.59 ns |  92.14 ns | 2,610.3 ns | 2,921.8 ns |   364,177.3 |  3.72 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 5,743.4 ns | 3,146.51 ns | 172.47 ns |  99.58 ns | 5,560.3 ns | 5,902.8 ns |   174,113.0 |  7.79 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 9,418.8 ns | 1,915.20 ns | 104.98 ns |  60.61 ns | 9,309.6 ns | 9,518.9 ns |   106,170.6 | 12.78 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
