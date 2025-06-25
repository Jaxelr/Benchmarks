# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     87.02 ns |   104.080 ns |  5.705 ns |  3.294 ns |     82.30 ns |     93.36 ns | 11,491,184.3 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    116.30 ns |    18.039 ns |  0.989 ns |  0.571 ns |    115.56 ns |    117.42 ns |  8,598,351.9 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    128.00 ns |   101.022 ns |  5.537 ns |  3.197 ns |    123.67 ns |    134.24 ns |  7,812,301.3 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    130.10 ns |     5.446 ns |  0.299 ns |  0.172 ns |    129.75 ns |    130.28 ns |  7,686,449.3 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    131.80 ns |    55.520 ns |  3.043 ns |  1.757 ns |    129.07 ns |    135.08 ns |  7,587,111.8 | 0.0393 |     248 B |
| ReplaceString        | ****(...)**** [500]  |  6,248.30 ns | 1,424.660 ns | 78.090 ns | 45.086 ns |  6,179.28 ns |  6,333.06 ns |    160,043.5 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  6,525.47 ns | 1,812.834 ns | 99.368 ns | 57.370 ns |  6,411.70 ns |  6,595.24 ns |    153,245.7 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 12,414.64 ns |   110.152 ns |  6.038 ns |  3.486 ns | 12,408.37 ns | 12,420.41 ns |     80,550.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,706.81 ns |   217.479 ns | 11.921 ns |  6.882 ns | 12,698.05 ns | 12,720.39 ns |     78,697.9 | 0.3204 |    2072 B |
