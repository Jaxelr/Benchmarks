# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).


``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |        array | value |       Mean |       Error |    StdDev |    StdErr |        Min |        Max |        Op/s | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo |  Int32[1000] |     4 |   188.9 ns |   108.18 ns |   5.93 ns |   3.42 ns |   183.3 ns |   195.1 ns | 5,295,204.1 |  0.37 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |     4 |   267.5 ns |   151.65 ns |   8.31 ns |   4.80 ns |   259.4 ns |   276.0 ns | 3,738,086.7 |  0.53 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |     4 |   509.3 ns |    98.83 ns |   5.42 ns |   3.13 ns |   504.6 ns |   515.3 ns | 1,963,418.7 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |     4 |   726.7 ns |   332.35 ns |  18.22 ns |  10.52 ns |   706.6 ns |   742.2 ns | 1,376,101.6 |  1.43 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendConcat | Int32[10000] |     4 | 2,295.0 ns |   885.24 ns |  48.52 ns |  28.01 ns | 2,240.7 ns | 2,334.1 ns |   435,729.9 |  4.51 |  6.3667 | 0.9079 |  39.23 KB |        9.96 |
| AppendCopyTo | Int32[10000] |     4 | 2,482.4 ns | 5,005.94 ns | 274.39 ns | 158.42 ns | 2,252.4 ns | 2,786.2 ns |   402,828.7 |  4.87 |  6.3286 | 0.9003 |  39.09 KB |        9.93 |
|       Append | Int32[10000] |     4 | 5,143.2 ns | 3,728.39 ns | 204.37 ns | 117.99 ns | 4,930.5 ns | 5,338.1 ns |   194,430.7 | 10.10 |  6.3248 | 0.9003 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |     4 | 8,434.3 ns | 1,274.33 ns |  69.85 ns |  40.33 ns | 8,377.1 ns | 8,512.2 ns |   118,562.9 | 16.56 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo |  Int32[1000] |   101 |   206.7 ns |   157.68 ns |   8.64 ns |   4.99 ns |   199.4 ns |   216.3 ns | 4,837,430.6 |  0.39 |  0.6425 | 0.0095 |   3.94 KB |        1.00 |
| AppendConcat |  Int32[1000] |   101 |   297.1 ns |     9.25 ns |   0.51 ns |   0.29 ns |   296.8 ns |   297.7 ns | 3,365,939.0 |  0.56 |  0.6657 | 0.0105 |   4.08 KB |        1.04 |
|       Append |  Int32[1000] |   101 |   527.1 ns |   442.25 ns |  24.24 ns |  14.00 ns |   507.4 ns |   554.2 ns | 1,897,174.0 |  1.00 |  0.6418 | 0.0095 |   3.94 KB |        1.00 |
| AppendToList |  Int32[1000] |   101 |   768.7 ns |   452.48 ns |  24.80 ns |  14.32 ns |   748.4 ns |   796.4 ns | 1,300,829.6 |  1.46 |  2.5673 | 0.1278 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] |   101 | 2,173.1 ns | 1,958.56 ns | 107.36 ns |  61.98 ns | 2,098.7 ns | 2,296.2 ns |   460,168.4 |  4.13 |  6.3286 | 0.9003 |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] |   101 | 2,345.5 ns |   898.08 ns |  49.23 ns |  28.42 ns | 2,304.9 ns | 2,400.3 ns |   426,343.2 |  4.46 |  6.3667 | 0.9079 |  39.23 KB |        9.96 |
|       Append | Int32[10000] |   101 | 4,960.2 ns | 1,879.80 ns | 103.04 ns |  59.49 ns | 4,859.5 ns | 5,065.5 ns |   201,602.9 |  9.42 |  6.3248 | 0.9003 |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] |   101 | 8,592.1 ns | 4,695.77 ns | 257.39 ns | 148.60 ns | 8,326.5 ns | 8,840.4 ns |   116,386.1 | 16.31 | 25.4211 | 8.4686 | 156.36 KB |       39.71 |
