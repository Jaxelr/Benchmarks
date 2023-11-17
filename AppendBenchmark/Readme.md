# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |    266.0 ns |     71.69 ns |   3.93 ns |   2.27 ns |    263.3 ns |    270.5 ns | 3,759,993.2 |  0.39 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |    402.3 ns |    431.80 ns |  23.67 ns |  13.67 ns |    375.9 ns |    421.4 ns | 2,485,504.3 |  0.59 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |    686.6 ns |    956.26 ns |  52.42 ns |  30.26 ns |    655.4 ns |    747.1 ns | 1,456,399.4 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |  1,038.4 ns |    818.10 ns |  44.84 ns |  25.89 ns |    992.8 ns |  1,082.4 ns |   963,038.6 |  1.52 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |  3,338.7 ns |    553.83 ns |  30.36 ns |  17.53 ns |  3,304.0 ns |  3,360.3 ns |   299,518.0 |  4.88 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |  3,519.6 ns |    913.18 ns |  50.05 ns |  28.90 ns |  3,490.2 ns |  3,577.4 ns |   284,125.6 |  5.15 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     |  8,906.8 ns | 12,828.98 ns | 703.20 ns | 405.99 ns |  8,276.6 ns |  9,665.3 ns |   112,273.5 | 13.03 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 12,830.2 ns |  7,313.97 ns | 400.90 ns | 231.46 ns | 12,373.0 ns | 13,121.5 ns |    77,941.1 | 18.78 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |             |              |           |           |             |             |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |    232.8 ns |     42.28 ns |   2.32 ns |   1.34 ns |    231.1 ns |    235.4 ns | 4,295,496.4 |  0.37 |  0.6423 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |    348.6 ns |    769.37 ns |  42.17 ns |  24.35 ns |    310.3 ns |    393.8 ns | 2,868,297.9 |  0.56 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |    623.3 ns |    514.08 ns |  28.18 ns |  16.27 ns |    592.8 ns |    648.3 ns | 1,604,300.3 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |    894.3 ns |    206.60 ns |  11.32 ns |   6.54 ns |    884.1 ns |    906.5 ns | 1,118,136.3 |  1.44 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   |  3,421.2 ns |  2,043.49 ns | 112.01 ns |  64.67 ns |  3,354.1 ns |  3,550.6 ns |   292,291.0 |  5.49 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   |  4,055.7 ns |  3,646.52 ns | 199.88 ns | 115.40 ns |  3,857.7 ns |  4,257.4 ns |   246,565.3 |  6.53 |  6.3629 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   |  6,805.3 ns |  5,649.81 ns | 309.69 ns | 178.80 ns |  6,543.0 ns |  7,147.0 ns |   146,943.3 | 10.92 |  6.3171 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 12,878.4 ns |  6,553.42 ns | 359.21 ns | 207.39 ns | 12,546.9 ns | 13,260.1 ns |    77,649.1 | 20.70 | 25.4211 | 8.4229 | 156.36 KB |       39.71 |
