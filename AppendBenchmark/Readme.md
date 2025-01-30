# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   189.3 ns |    89.81 ns |   4.92 ns |   2.84 ns |   184.3 ns |   194.2 ns | 5,281,332.3 |  0.40 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   202.7 ns |   228.07 ns |  12.50 ns |   7.22 ns |   193.0 ns |   216.8 ns | 4,933,958.3 |  0.43 |  0.6561 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   475.0 ns |    79.70 ns |   4.37 ns |   2.52 ns |   471.2 ns |   479.8 ns | 2,105,176.9 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   692.9 ns |   787.98 ns |  43.19 ns |  24.94 ns |   656.7 ns |   740.7 ns | 1,443,253.8 |  1.46 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,064.2 ns |    87.61 ns |   4.80 ns |   2.77 ns | 2,058.9 ns | 2,068.1 ns |   484,439.5 |  4.35 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,182.1 ns |   233.25 ns |  12.79 ns |   7.38 ns | 2,168.2 ns | 2,193.4 ns |   458,282.9 |  4.59 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 4,908.4 ns |   673.75 ns |  36.93 ns |  21.32 ns | 4,876.2 ns | 4,948.7 ns |   203,733.8 | 10.33 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 7,899.4 ns | 1,818.76 ns |  99.69 ns |  57.56 ns | 7,804.5 ns | 8,003.2 ns |   126,592.2 | 16.63 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   175.2 ns |    56.54 ns |   3.10 ns |   1.79 ns |   172.0 ns |   178.2 ns | 5,707,413.5 |  0.37 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   199.2 ns |    87.82 ns |   4.81 ns |   2.78 ns |   195.5 ns |   204.6 ns | 5,021,072.1 |  0.42 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   474.5 ns |   132.46 ns |   7.26 ns |   4.19 ns |   468.9 ns |   482.7 ns | 2,107,308.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   711.1 ns |   595.81 ns |  32.66 ns |  18.86 ns |   680.9 ns |   745.8 ns | 1,406,266.7 |  1.50 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,165.9 ns |   283.63 ns |  15.55 ns |   8.98 ns | 2,148.1 ns | 2,177.0 ns |   461,703.9 |  4.56 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,211.7 ns | 1,472.36 ns |  80.70 ns |  46.59 ns | 2,159.8 ns | 2,304.7 ns |   452,131.2 |  4.66 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,891.8 ns | 2,390.70 ns | 131.04 ns |  75.66 ns | 4,806.6 ns | 5,042.7 ns |   204,422.1 | 10.31 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,278.0 ns | 8,352.90 ns | 457.85 ns | 264.34 ns | 7,996.8 ns | 8,806.4 ns |   120,801.6 | 17.45 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
