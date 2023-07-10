# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.304
  [Host]   : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |       Error |    StdDev |    StdErr |        Min |        Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   200.3 ns |   439.91 ns |  24.11 ns |  13.92 ns |   182.6 ns |   227.8 ns | 4,991,580.3 |  0.37 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   249.5 ns |   160.52 ns |   8.80 ns |   5.08 ns |   242.6 ns |   259.4 ns | 4,007,510.5 |  0.47 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   535.5 ns |   151.52 ns |   8.31 ns |   4.80 ns |   528.9 ns |   544.8 ns | 1,867,571.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   670.3 ns |    74.38 ns |   4.08 ns |   2.35 ns |   667.0 ns |   674.8 ns | 1,491,950.1 |  1.25 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |     4 | 2,097.6 ns |   683.67 ns |  37.47 ns |  21.64 ns | 2,058.1 ns | 2,132.6 ns |   476,741.8 |  3.92 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |     4 | 2,206.1 ns |    51.27 ns |   2.81 ns |   1.62 ns | 2,202.9 ns | 2,208.2 ns |   453,287.9 |  4.12 |  6.3667 |      - |  39.23 KB |        9.96 |
|       Append | Int32[10000] |     4 | 4,926.9 ns | 2,616.67 ns | 143.43 ns |  82.81 ns | 4,786.8 ns | 5,073.4 ns |   202,968.4 |  9.20 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 9,263.4 ns | 9,487.97 ns | 520.07 ns | 300.26 ns | 8,675.6 ns | 9,663.6 ns |   107,951.1 | 17.31 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   180.3 ns |   133.02 ns |   7.29 ns |   4.21 ns |   173.8 ns |   188.2 ns | 5,545,009.1 |  0.36 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   447.2 ns |   827.17 ns |  45.34 ns |  26.18 ns |   419.9 ns |   499.6 ns | 2,235,914.8 |  0.89 |  0.6657 |      - |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   500.5 ns |    52.39 ns |   2.87 ns |   1.66 ns |   497.2 ns |   502.6 ns | 1,998,119.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 | 1,020.7 ns | 2,619.64 ns | 143.59 ns |  82.90 ns |   856.3 ns | 1,121.1 ns |   979,685.0 |  2.04 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 | 2,032.4 ns |   108.15 ns |   5.93 ns |   3.42 ns | 2,028.5 ns | 2,039.2 ns |   492,025.0 |  4.06 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 2,306.1 ns | 1,090.91 ns |  59.80 ns |  34.52 ns | 2,269.0 ns | 2,375.1 ns |   433,625.5 |  4.61 |  6.3667 |      - |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 | 4,810.3 ns |   629.04 ns |  34.48 ns |  19.91 ns | 4,770.6 ns | 4,833.2 ns |   207,886.9 |  9.61 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 7,822.0 ns |   504.16 ns |  27.63 ns |  15.95 ns | 7,797.6 ns | 7,852.0 ns |   127,843.8 | 15.63 | 25.4211 | 5.6458 | 156.36 KB |       39.71 |
