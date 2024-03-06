# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |    147.1 ns |     58.15 ns |     3.19 ns |     1.84 ns |    143.4 ns |    149.4 ns | 6,799,476.7 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    197.1 ns |     47.45 ns |     2.60 ns |     1.50 ns |    194.1 ns |    198.7 ns | 5,073,435.9 |      - |         - |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    233.6 ns |    332.91 ns |    18.25 ns |    10.54 ns |    221.7 ns |    254.6 ns | 4,280,418.3 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    253.9 ns |    113.42 ns |     6.22 ns |     3.59 ns |    246.7 ns |    257.8 ns | 3,938,265.8 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    348.3 ns |    283.59 ns |    15.54 ns |     8.97 ns |    338.3 ns |    366.2 ns | 2,870,888.5 | 0.0393 |     248 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 11,726.3 ns | 27,785.46 ns | 1,523.01 ns |   879.31 ns | 10,645.8 ns | 13,468.2 ns |    85,278.2 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [500]  | 13,777.8 ns | 21,652.54 ns | 1,186.85 ns |   685.23 ns | 12,818.0 ns | 15,104.9 ns |    72,580.4 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 21,329.6 ns | 24,017.77 ns | 1,316.49 ns |   760.08 ns | 19,844.7 ns | 22,354.0 ns |    46,883.3 | 0.3052 |    2072 B |
| ReplaceString        | ****(...)**** [1000] | 34,986.8 ns | 33,116.61 ns | 1,815.23 ns | 1,048.03 ns | 32,893.0 ns | 36,119.3 ns |    28,582.2 |      - |      24 B |
