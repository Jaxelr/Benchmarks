# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   187.1 ns |    42.32 ns |   2.32 ns |   1.34 ns |   185.6 ns |   189.7 ns | 5,345,896.8 |  0.36 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   221.5 ns |    72.93 ns |   4.00 ns |   2.31 ns |   217.5 ns |   225.5 ns | 4,514,404.1 |  0.42 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   526.5 ns |    87.52 ns |   4.80 ns |   2.77 ns |   521.8 ns |   531.4 ns | 1,899,479.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   700.9 ns |   330.64 ns |  18.12 ns |  10.46 ns |   680.0 ns |   711.5 ns | 1,426,700.7 |  1.33 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,270.8 ns |   817.36 ns |  44.80 ns |  25.87 ns | 2,224.6 ns | 2,314.1 ns |   440,382.2 |  4.31 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,361.3 ns |   987.13 ns |  54.11 ns |  31.24 ns | 2,323.8 ns | 2,423.3 ns |   423,500.6 |  4.49 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 5,275.1 ns | 3,603.05 ns | 197.50 ns | 114.02 ns | 5,052.5 ns | 5,429.4 ns |   189,571.5 | 10.02 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,561.1 ns | 3,237.56 ns | 177.46 ns | 102.46 ns | 8,402.4 ns | 8,752.7 ns |   116,807.7 | 16.26 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   186.0 ns |    99.40 ns |   5.45 ns |   3.15 ns |   180.1 ns |   190.8 ns | 5,376,987.4 |  0.36 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   232.8 ns |   264.15 ns |  14.48 ns |   8.36 ns |   219.4 ns |   248.2 ns | 4,296,025.5 |  0.45 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   521.4 ns |   216.04 ns |  11.84 ns |   6.84 ns |   513.8 ns |   535.1 ns | 1,917,812.3 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   788.8 ns |   413.82 ns |  22.68 ns |  13.10 ns |   768.0 ns |   813.0 ns | 1,267,780.4 |  1.51 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,184.4 ns |   799.87 ns |  43.84 ns |  25.31 ns | 2,133.8 ns | 2,210.0 ns |   457,782.8 |  4.19 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,299.1 ns |   137.85 ns |   7.56 ns |   4.36 ns | 2,294.0 ns | 2,307.8 ns |   434,959.7 |  4.41 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,928.1 ns | 1,627.26 ns |  89.20 ns |  51.50 ns | 4,867.8 ns | 5,030.5 ns |   202,918.8 |  9.45 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,361.6 ns |   657.00 ns |  36.01 ns |  20.79 ns | 8,321.3 ns | 8,390.6 ns |   119,594.4 | 16.04 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
