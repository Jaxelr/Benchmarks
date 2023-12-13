# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     94.70 ns |     31.10 ns |   1.705 ns |   0.984 ns |     93.70 ns |     96.67 ns | 10,559,945.8 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    163.79 ns |    135.54 ns |   7.429 ns |   4.289 ns |    155.48 ns |    169.80 ns |  6,105,477.4 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    166.82 ns |    237.98 ns |  13.044 ns |   7.531 ns |    158.66 ns |    181.86 ns |  5,994,494.7 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    189.00 ns |    185.76 ns |  10.182 ns |   5.879 ns |    177.51 ns |    196.91 ns |  5,290,901.9 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    207.85 ns |    857.67 ns |  47.012 ns |  27.142 ns |    169.20 ns |    260.19 ns |  4,811,144.9 |      - |         - |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,326.20 ns |  1,133.22 ns |  62.116 ns |  35.863 ns |  7,254.48 ns |  7,362.55 ns |    136,496.3 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [500]  |  7,769.11 ns |  7,918.10 ns | 434.018 ns | 250.580 ns |  7,455.49 ns |  8,264.45 ns |    128,714.8 |      - |      24 B |
| ReplaceString        | ****(...)**** [1000] | 14,555.73 ns |  1,369.08 ns |  75.044 ns |  43.327 ns | 14,469.09 ns | 14,600.36 ns |     68,701.5 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 15,756.70 ns | 13,597.73 ns | 745.338 ns | 430.321 ns | 14,900.89 ns | 16,263.40 ns |     63,465.0 | 0.3052 |    2072 B |
