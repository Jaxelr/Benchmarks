# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |       Error |     StdDev |     StdErr |         Min |          Q1 |      Median |          Q3 |         Max |         Op/s |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |--------------------- |------------:|------------:|-----------:|-----------:|------------:|------------:|------------:|------------:|------------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    77.28 ns |    47.85 ns |   2.623 ns |   1.514 ns |    74.55 ns |    76.03 ns |    77.50 ns |    78.64 ns |    79.78 ns | 12,940,274.2 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder | Rando(...)tween [39] |   190.93 ns |    13.28 ns |   0.728 ns |   0.420 ns |   190.46 ns |   190.51 ns |   190.55 ns |   191.16 ns |   191.76 ns |  5,237,652.4 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   215.71 ns |    58.38 ns |   3.200 ns |   1.848 ns |   212.25 ns |   214.29 ns |   216.33 ns |   217.44 ns |   218.56 ns |  4,635,800.1 | 0.0470 |      - |     296 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |   248.01 ns |   265.31 ns |  14.542 ns |   8.396 ns |   234.61 ns |   240.27 ns |   245.94 ns |   254.70 ns |   263.47 ns |  4,032,176.1 |      - |      - |         - |
|  ReplaceRegexBuilder |  ****(...)**** [500] |   279.05 ns |   211.42 ns |  11.589 ns |   6.691 ns |   266.76 ns |   273.69 ns |   280.62 ns |   285.20 ns |   289.78 ns |  3,583,530.9 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] | 3,931.14 ns | 2,998.11 ns | 164.337 ns |  94.880 ns | 3,830.33 ns | 3,836.32 ns | 3,842.32 ns | 3,981.54 ns | 4,120.77 ns |    254,379.1 | 1.5068 | 0.0114 |   9,456 B |
|        ReplaceString |  ****(...)**** [500] | 4,062.41 ns | 9,268.26 ns | 508.025 ns | 293.308 ns | 3,531.13 ns | 3,821.90 ns | 4,112.67 ns | 4,328.05 ns | 4,543.44 ns |    246,159.2 |      - |      - |      24 B |
|        ReplaceString | ****(...)**** [1000] | 7,386.89 ns | 3,940.99 ns | 216.019 ns | 124.719 ns | 7,170.71 ns | 7,278.97 ns | 7,387.23 ns | 7,494.99 ns | 7,602.74 ns |    135,374.9 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 7,420.72 ns | 5,213.26 ns | 285.756 ns | 164.981 ns | 7,250.72 ns | 7,255.76 ns | 7,260.81 ns | 7,505.72 ns | 7,750.63 ns |    134,757.9 | 2.3422 | 0.0305 |  14,712 B |
