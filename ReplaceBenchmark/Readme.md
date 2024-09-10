# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     89.90 ns |    21.20 ns |   1.162 ns |   0.671 ns |     88.94 ns |     91.19 ns | 11,123,547.9 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    150.74 ns |    26.83 ns |   1.471 ns |   0.849 ns |    149.10 ns |    151.95 ns |  6,634,122.0 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    152.37 ns |   111.30 ns |   6.101 ns |   3.522 ns |    146.86 ns |    158.93 ns |  6,563,052.3 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    160.01 ns |   234.23 ns |  12.839 ns |   7.413 ns |    152.19 ns |    174.83 ns |  6,249,715.2 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    222.12 ns | 1,757.16 ns |  96.316 ns |  55.608 ns |    160.39 ns |    333.10 ns |  4,502,027.0 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  7,218.49 ns |   802.29 ns |  43.976 ns |  25.390 ns |  7,191.50 ns |  7,269.23 ns |    138,533.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,347.04 ns | 1,409.27 ns |  77.247 ns |  44.599 ns |  7,281.69 ns |  7,432.29 ns |    136,109.2 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 14,356.22 ns | 1,134.37 ns |  62.179 ns |  35.899 ns | 14,315.12 ns | 14,427.76 ns |     69,656.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 15,208.54 ns | 5,108.31 ns | 280.004 ns | 161.660 ns | 14,936.73 ns | 15,496.07 ns |     65,752.6 | 0.3052 |    2072 B |
