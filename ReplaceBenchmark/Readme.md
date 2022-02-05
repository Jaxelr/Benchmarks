# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |      Error |    StdDev |  Gen 0 | Allocated |
|--------------------- |--------------------- |------------:|-----------:|----------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    116.3 ns |   106.4 ns |   5.83 ns | 0.0229 |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |    254.3 ns |   342.6 ns |  18.78 ns |      - |         - |
|  ReplaceRegexBuilder | ****(...)**** [1000] |    276.8 ns |   248.5 ns |  13.62 ns |      - |         - |
|  ReplaceRegexBuilder | Rando(...)tween [39] |    316.3 ns |   223.4 ns |  12.24 ns |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    443.0 ns |   687.5 ns |  37.69 ns | 0.0706 |     296 B |
| ReplaceStringBuilder |  ****(...)**** [500] |  4,810.3 ns | 2,111.4 ns | 115.73 ns | 2.2583 |   9,456 B |
|        ReplaceString |  ****(...)**** [500] |  5,870.4 ns | 3,065.6 ns | 168.04 ns |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] |  8,985.4 ns |   589.5 ns |  32.31 ns | 3.5095 |  14,712 B |
|        ReplaceString | ****(...)**** [1000] | 10,922.3 ns | 5,636.1 ns | 308.93 ns |      - |      24 B |
