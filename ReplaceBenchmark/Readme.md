# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |        Error |     StdDev |     StdErr |         Min |        Max |         Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |------------:|-------------:|-----------:|-----------:|------------:|-----------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    87.80 ns |    196.38 ns |  10.764 ns |   6.215 ns |    79.92 ns |   100.1 ns | 11,388,980.7 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |   216.07 ns |     80.19 ns |   4.396 ns |   2.538 ns |   212.75 ns |   221.1 ns |  4,628,091.5 |      - |      - |         - |
|  ReplaceRegexBuilder | Rando(...)tween [39] |   226.24 ns |    350.21 ns |  19.196 ns |  11.083 ns |   214.20 ns |   248.4 ns |  4,419,994.3 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   234.76 ns |    668.13 ns |  36.622 ns |  21.144 ns |   208.21 ns |   276.5 ns |  4,259,759.6 | 0.0393 |      - |     248 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |   251.81 ns |    319.44 ns |  17.510 ns |  10.109 ns |   232.50 ns |   266.6 ns |  3,971,203.1 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] | 3,352.19 ns |  8,467.98 ns | 464.159 ns | 267.982 ns | 3,071.80 ns | 3,888.0 ns |    298,312.3 | 1.4992 | 0.0076 |    9408 B |
|        ReplaceString |  ****(...)**** [500] | 5,062.91 ns |  1,422.63 ns |  77.979 ns |  45.021 ns | 4,988.32 ns | 5,143.9 ns |    197,515.0 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 6,222.09 ns | 12,739.09 ns | 698.272 ns | 403.148 ns | 5,713.06 ns | 7,018.1 ns |    160,717.7 | 2.3346 | 0.0229 |   14664 B |
|        ReplaceString | ****(...)**** [1000] | 9,734.37 ns |  1,034.48 ns |  56.704 ns |  32.738 ns | 9,672.81 ns | 9,784.5 ns |    102,728.8 |      - |      - |      24 B |
