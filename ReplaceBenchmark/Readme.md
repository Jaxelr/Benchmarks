# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev     | StdErr    | Min          | Max          | Op/s         | Gen0   | Gen1   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|----------:|-------------:|-------------:|-------------:|-------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     73.19 ns |    28.43 ns |   1.558 ns |  0.900 ns |     71.44 ns |     74.43 ns | 13,662,397.9 | 0.0153 |      - |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    186.47 ns |    41.45 ns |   2.272 ns |  1.312 ns |    184.44 ns |    188.93 ns |  5,362,772.9 |      - |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    203.05 ns |    58.93 ns |   3.230 ns |  1.865 ns |    199.99 ns |    206.43 ns |  4,924,888.8 |      - |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    229.78 ns |    45.70 ns |   2.505 ns |  1.446 ns |    227.51 ns |    232.46 ns |  4,352,004.1 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    234.41 ns |    59.29 ns |   3.250 ns |  1.876 ns |    232.19 ns |    238.14 ns |  4,266,032.5 | 0.0393 |      - |     248 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  3,219.70 ns | 2,713.99 ns | 148.763 ns | 85.888 ns |  3,123.17 ns |  3,391.02 ns |    310,587.8 | 1.4992 | 0.0038 |    9408 B |
| ReplaceString        | ****(...)**** [500]  |  5,357.90 ns |   672.62 ns |  36.869 ns | 21.286 ns |  5,315.44 ns |  5,381.83 ns |    186,640.3 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] |  5,736.36 ns |   687.26 ns |  37.671 ns | 21.750 ns |  5,707.69 ns |  5,779.03 ns |    174,326.5 | 2.3346 | 0.0229 |   14664 B |
| ReplaceString        | ****(...)**** [1000] | 10,637.66 ns |   378.49 ns |  20.746 ns | 11.978 ns | 10,617.58 ns | 10,659.01 ns |     94,005.6 |      - |      - |      24 B |
