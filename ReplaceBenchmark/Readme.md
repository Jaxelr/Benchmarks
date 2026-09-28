# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error         | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|--------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     68.33 ns |    176.408 ns |   9.669 ns |   5.583 ns |     62.10 ns |     79.47 ns | 14,635,082.0 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     98.89 ns |     43.184 ns |   2.367 ns |   1.367 ns |     96.16 ns |    100.33 ns | 10,112,029.9 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    107.62 ns |      7.115 ns |   0.390 ns |   0.225 ns |    107.23 ns |    108.01 ns |  9,292,243.4 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    123.05 ns |     19.451 ns |   1.066 ns |   0.616 ns |    121.94 ns |    124.06 ns |  8,126,950.3 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    166.24 ns |     86.151 ns |   4.722 ns |   2.726 ns |    161.18 ns |    170.53 ns |  6,015,264.5 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,767.62 ns |  1,067.588 ns |  58.518 ns |  33.785 ns |  4,723.48 ns |  4,833.99 ns |    209,748.4 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,837.28 ns |    310.089 ns |  16.997 ns |   9.813 ns |  5,826.81 ns |  5,856.89 ns |    171,312.7 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,896.29 ns |  4,132.125 ns | 226.496 ns | 130.767 ns |  9,661.26 ns | 10,113.16 ns |    101,048.0 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 14,453.99 ns | 11,825.987 ns | 648.222 ns | 374.251 ns | 13,765.87 ns | 15,053.12 ns |     69,185.1 | 0.4883 |    2072 B |
