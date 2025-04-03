# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error       | StdDev    | StdErr   | Min         | Max         | Op/s        | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|------------:|----------:|---------:|------------:|------------:|------------:|-------:|----------:|
| ReplaceRegexBuilder  | ****(...)**** [500]  |    126.9 ns |    50.14 ns |   2.75 ns |  1.59 ns |    123.8 ns |    129.0 ns | 7,881,369.4 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    134.5 ns |    24.52 ns |   1.34 ns |  0.78 ns |    133.2 ns |    135.9 ns | 7,434,648.9 |      - |         - |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    149.4 ns |   118.57 ns |   6.50 ns |  3.75 ns |    142.3 ns |    155.0 ns | 6,692,371.2 |      - |         - |
| ReplaceString        | Rando(...)tween [39] |    164.1 ns |    73.31 ns |   4.02 ns |  2.32 ns |    160.5 ns |    168.4 ns | 6,094,417.5 | 0.0153 |      96 B |
| ReplaceStringBuilder | Rando(...)tween [39] |    203.0 ns |   134.62 ns |   7.38 ns |  4.26 ns |    196.5 ns |    211.0 ns | 4,925,908.8 | 0.0391 |     248 B |
| ReplaceString        | ****(...)**** [500]  |  6,206.2 ns |   478.56 ns |  26.23 ns | 15.14 ns |  6,178.7 ns |  6,230.9 ns |   161,129.8 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  6,488.9 ns | 2,626.17 ns | 143.95 ns | 83.11 ns |  6,398.2 ns |  6,654.9 ns |   154,109.3 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 12,359.2 ns |   614.37 ns |  33.68 ns | 19.44 ns | 12,326.3 ns | 12,393.6 ns |    80,911.3 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,867.7 ns | 2,071.91 ns | 113.57 ns | 65.57 ns | 12,758.0 ns | 12,984.8 ns |    77,714.3 | 0.3204 |    2072 B |
