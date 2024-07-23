# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     88.28 ns |    26.11 ns |   1.431 ns |   0.826 ns |     86.88 ns |     89.74 ns | 11,327,814.3 | 0.0153 |      96 B |
| ReplaceStringBuilder | Rando(...)tween [39] |    141.44 ns |    22.16 ns |   1.214 ns |   0.701 ns |    140.31 ns |    142.72 ns |  7,069,931.9 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    148.28 ns |    17.95 ns |   0.984 ns |   0.568 ns |    147.22 ns |    149.16 ns |  6,743,894.1 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    161.67 ns |    34.91 ns |   1.914 ns |   1.105 ns |    159.51 ns |    163.15 ns |  6,185,558.9 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    167.71 ns |    22.42 ns |   1.229 ns |   0.710 ns |    166.32 ns |    168.66 ns |  5,962,788.6 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  7,322.76 ns | 2,239.83 ns | 122.773 ns |  70.883 ns |  7,239.00 ns |  7,463.69 ns |    136,560.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 11,270.67 ns | 6,215.34 ns | 340.684 ns | 196.694 ns | 10,907.45 ns | 11,583.12 ns |     88,725.9 | 0.1678 |    1072 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 14,755.41 ns | 3,494.51 ns | 191.546 ns | 110.589 ns | 14,560.12 ns | 14,942.98 ns |     67,771.8 | 0.3204 |    2072 B |
| ReplaceString        | ****(...)**** [1000] | 14,959.42 ns | 5,066.93 ns | 277.735 ns | 160.351 ns | 14,638.87 ns | 15,128.33 ns |     66,847.5 |      - |      24 B |
