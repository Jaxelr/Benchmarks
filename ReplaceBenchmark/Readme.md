# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1555)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |       Error |      StdDev |    StdErr |         Min |         Max |        Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |------------:|------------:|------------:|----------:|------------:|------------:|------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    139.3 ns |    338.4 ns |    18.55 ns |  10.71 ns |    128.5 ns |    160.8 ns | 7,176,789.2 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |    285.3 ns |    882.7 ns |    48.38 ns |  27.93 ns |    256.0 ns |    341.1 ns | 3,505,657.7 |      - |      - |         - |
|  ReplaceRegexBuilder | ****(...)**** [1000] |    289.5 ns |    474.6 ns |    26.02 ns |  15.02 ns |    268.4 ns |    318.6 ns | 3,453,810.9 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    299.5 ns |    249.8 ns |    13.69 ns |   7.90 ns |    283.7 ns |    308.3 ns | 3,339,012.5 | 0.0391 |      - |     248 B |
|  ReplaceRegexBuilder | Rando(...)tween [39] |    319.5 ns |    679.7 ns |    37.26 ns |  21.51 ns |    279.1 ns |    352.4 ns | 3,129,697.9 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] |  4,320.7 ns |  9,196.5 ns |   504.09 ns | 291.04 ns |  3,881.4 ns |  4,871.1 ns |   231,441.8 | 1.4954 |      - |    9408 B |
|        ReplaceString |  ****(...)**** [500] |  5,921.6 ns |  7,395.8 ns |   405.39 ns | 234.05 ns |  5,454.7 ns |  6,184.4 ns |   168,873.1 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] |  7,763.5 ns |  5,836.1 ns |   319.90 ns | 184.69 ns |  7,432.2 ns |  8,070.6 ns |   128,807.1 | 2.3346 | 0.0153 |   14664 B |
|        ReplaceString | ****(...)**** [1000] | 12,847.3 ns | 19,222.5 ns | 1,053.65 ns | 608.32 ns | 11,737.3 ns | 13,833.6 ns |    77,837.2 |      - |      - |      24 B |
