# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error     | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|----------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   124.4 ns |   9.15 ns |  0.50 ns |  0.29 ns |   123.9 ns |   124.9 ns | 8,037,805.0 |  0.36 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   148.4 ns |   6.07 ns |  0.33 ns |  0.19 ns |   148.0 ns |   148.6 ns | 6,740,729.3 |  0.43 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   345.3 ns |  16.59 ns |  0.91 ns |  0.53 ns |   344.6 ns |   346.3 ns | 2,895,967.7 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   456.8 ns |  45.34 ns |  2.49 ns |  1.43 ns |   455.2 ns |   459.6 ns | 2,189,215.7 |  1.32 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   926.2 ns | 106.10 ns |  5.82 ns |  3.36 ns |   922.8 ns |   932.9 ns | 1,079,732.2 |  2.68 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     |   989.3 ns | 162.58 ns |  8.91 ns |  5.14 ns |   983.6 ns |   999.6 ns | 1,010,781.6 |  2.87 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 2,978.4 ns | 403.54 ns | 22.12 ns | 12.77 ns | 2,964.7 ns | 3,003.9 ns |   335,748.2 |  8.63 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,313.8 ns | 150.30 ns |  8.24 ns |  4.76 ns | 3,305.8 ns | 3,322.3 ns |   301,767.7 |  9.60 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |           |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   126.8 ns |  21.14 ns |  1.16 ns |  0.67 ns |   125.8 ns |   128.0 ns | 7,886,670.8 |  0.37 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   158.1 ns | 199.73 ns | 10.95 ns |  6.32 ns |   151.2 ns |   170.7 ns | 6,324,791.8 |  0.46 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   346.3 ns |  83.56 ns |  4.58 ns |  2.64 ns |   342.2 ns |   351.3 ns | 2,887,654.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   462.3 ns | 189.00 ns | 10.36 ns |  5.98 ns |   455.7 ns |   474.2 ns | 2,163,139.3 |  1.34 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,007.1 ns | 495.44 ns | 27.16 ns | 15.68 ns |   980.8 ns | 1,035.1 ns |   992,915.2 |  2.91 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,007.3 ns | 200.49 ns | 10.99 ns |  6.34 ns |   999.2 ns | 1,019.8 ns |   992,716.6 |  2.91 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 2,920.0 ns | 180.03 ns |  9.87 ns |  5.70 ns | 2,911.7 ns | 2,930.9 ns |   342,462.7 |  8.43 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 4,166.9 ns | 177.25 ns |  9.72 ns |  5.61 ns | 4,155.7 ns | 4,172.8 ns |   239,988.4 | 12.03 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
