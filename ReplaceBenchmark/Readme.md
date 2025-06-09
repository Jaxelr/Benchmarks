# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4202)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |    105.8 ns |     41.43 ns |   2.27 ns |   1.31 ns |    104.1 ns |    108.4 ns | 9,450,176.2 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    162.4 ns |    178.53 ns |   9.79 ns |   5.65 ns |    156.7 ns |    173.7 ns | 6,159,482.0 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    204.9 ns |    310.76 ns |  17.03 ns |   9.83 ns |    193.3 ns |    224.4 ns | 4,880,666.2 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    228.7 ns |    448.46 ns |  24.58 ns |  14.19 ns |    210.7 ns |    256.7 ns | 4,372,855.4 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    238.9 ns |    281.77 ns |  15.44 ns |   8.92 ns |    222.0 ns |    252.2 ns | 4,185,286.7 |      - |         - |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,247.4 ns |  1,836.53 ns | 100.67 ns |  58.12 ns |  7,137.6 ns |  7,335.3 ns |   137,979.6 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [500]  |  7,250.8 ns |  4,246.29 ns | 232.75 ns | 134.38 ns |  6,996.1 ns |  7,452.4 ns |   137,915.5 |      - |      24 B |
| ReplaceString        | ****(...)**** [1000] | 14,262.5 ns |  6,769.77 ns | 371.07 ns | 214.24 ns | 13,856.5 ns | 14,584.1 ns |    70,114.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 17,888.4 ns | 11,576.60 ns | 634.55 ns | 366.36 ns | 17,181.3 ns | 18,408.2 ns |    55,902.2 | 0.3052 |    2072 B |
