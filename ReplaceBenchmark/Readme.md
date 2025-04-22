# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     94.02 ns |     31.16 ns |   1.708 ns |   0.986 ns |     92.70 ns |     95.95 ns | 10,635,780.3 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    168.77 ns |    258.04 ns |  14.144 ns |   8.166 ns |    155.01 ns |    183.27 ns |  5,925,228.0 |      - |         - |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    171.73 ns |    444.39 ns |  24.359 ns |  14.064 ns |    155.87 ns |    199.78 ns |  5,823,164.8 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    175.90 ns |    343.51 ns |  18.829 ns |  10.871 ns |    154.17 ns |    187.52 ns |  5,685,164.5 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    207.23 ns |    157.38 ns |   8.626 ns |   4.980 ns |    198.86 ns |    216.09 ns |  4,825,648.4 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  9,215.63 ns |  5,121.90 ns | 280.749 ns | 162.090 ns |  8,898.43 ns |  9,432.16 ns |    108,511.3 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 10,353.89 ns |  1,651.67 ns |  90.534 ns |  52.270 ns | 10,259.19 ns | 10,439.59 ns |     96,582.0 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 15,357.47 ns | 13,323.96 ns | 730.331 ns | 421.657 ns | 14,930.22 ns | 16,200.76 ns |     65,114.9 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 16,665.41 ns |  9,997.22 ns | 547.981 ns | 316.377 ns | 16,268.18 ns | 17,290.57 ns |     60,004.5 | 0.3052 |    2072 B |
