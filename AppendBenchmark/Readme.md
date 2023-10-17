# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|------------:|------------:|------------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    400.3 ns |    460.1 ns |    25.22 ns |    14.56 ns |    374.7 ns |    425.1 ns | 2,498,199.4 |  0.25 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    541.4 ns |  1,777.0 ns |    97.40 ns |    56.24 ns |    464.6 ns |    650.9 ns | 1,847,140.7 |  0.33 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |  1,648.5 ns |  5,534.1 ns |   303.34 ns |   175.14 ns |  1,342.2 ns |  1,948.8 ns |   606,611.9 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |  2,257.0 ns | 13,144.4 ns |   720.49 ns |   415.97 ns |  1,782.5 ns |  3,086.1 ns |   443,065.0 |  1.35 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |  3,448.3 ns |  3,470.1 ns |   190.21 ns |   109.82 ns |  3,284.0 ns |  3,656.7 ns |   290,001.7 |  2.13 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |  4,846.6 ns |  7,796.9 ns |   427.37 ns |   246.74 ns |  4,393.2 ns |  5,242.0 ns |   206,329.3 |  3.04 |  6.3629 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     | 12,633.2 ns | 25,451.2 ns | 1,395.07 ns |   805.44 ns | 11,328.5 ns | 14,103.8 ns |    79,156.7 |  7.74 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 18,749.9 ns | 37,766.8 ns | 2,070.12 ns | 1,195.19 ns | 16,360.3 ns | 19,998.5 ns |    53,333.6 | 11.66 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
|              |              |       |             |             |             |             |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    400.1 ns |    633.6 ns |    34.73 ns |    20.05 ns |    361.3 ns |    428.1 ns | 2,499,249.0 |  0.52 |  0.6409 |      - |   3.94 KB |        1.00 |
| Append       | Int32[1000]  | 101   |    788.6 ns |  1,924.2 ns |   105.47 ns |    60.90 ns |    668.5 ns |    865.9 ns | 1,268,057.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    990.4 ns |  6,002.8 ns |   329.03 ns |   189.97 ns |    758.0 ns |  1,366.9 ns | 1,009,730.9 |  1.24 |  0.6657 |      - |   4.08 KB |        1.04 |
| AppendToList | Int32[1000]  | 101   |  1,673.4 ns |  3,742.6 ns |   205.14 ns |   118.44 ns |  1,438.8 ns |  1,819.0 ns |   597,582.9 |  2.12 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |  7,132.3 ns | 37,159.3 ns | 2,036.83 ns | 1,175.96 ns |  5,614.5 ns |  9,447.1 ns |   140,207.0 |  9.05 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  8,797.2 ns | 26,954.4 ns | 1,477.46 ns |   853.01 ns |  7,091.4 ns |  9,676.5 ns |   113,673.1 | 11.37 |  6.3629 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   |  9,573.2 ns | 21,768.3 ns | 1,193.19 ns |   688.89 ns |  8,226.3 ns | 10,498.0 ns |   104,458.6 | 12.38 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 16,584.8 ns | 40,618.6 ns | 2,226.44 ns | 1,285.44 ns | 15,277.3 ns | 19,155.6 ns |    60,296.1 | 21.20 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
