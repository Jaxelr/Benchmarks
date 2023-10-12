# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Gen1   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     80.32 ns |   140.24 ns |   7.687 ns |   4.438 ns |     75.86 ns |     89.20 ns | 12,449,549.6 | 0.0153 |      - |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    219.36 ns | 1,002.73 ns |  54.963 ns |  31.733 ns |    187.59 ns |    282.83 ns |  4,558,682.0 |      - |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    228.37 ns |    45.94 ns |   2.518 ns |   1.454 ns |    226.24 ns |    231.15 ns |  4,378,907.0 |      - |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    235.87 ns |   195.13 ns |  10.696 ns |   6.175 ns |    223.58 ns |    243.05 ns |  4,239,629.6 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    247.78 ns |   152.82 ns |   8.377 ns |   4.836 ns |    238.60 ns |    255.00 ns |  4,035,910.0 | 0.0391 |      - |     248 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  3,424.26 ns | 2,378.47 ns | 130.372 ns |  75.270 ns |  3,295.72 ns |  3,556.39 ns |    292,034.0 | 1.4992 | 0.0038 |    9408 B |
| ReplaceString        | ****(...)**** [500]  |  5,524.52 ns | 1,170.84 ns |  64.178 ns |  37.053 ns |  5,450.72 ns |  5,567.26 ns |    181,011.2 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] |  6,087.13 ns | 1,215.05 ns |  66.601 ns |  38.452 ns |  6,010.33 ns |  6,129.08 ns |    164,281.1 | 2.3346 | 0.0229 |   14664 B |
| ReplaceString        | ****(...)**** [1000] | 10,937.42 ns | 7,148.10 ns | 391.812 ns | 226.213 ns | 10,698.84 ns | 11,389.62 ns |     91,429.2 |      - |      - |      24 B |
