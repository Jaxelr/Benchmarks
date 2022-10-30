# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |       Error |     StdDev |     StdErr |         Min |         Max |         Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |------------:|------------:|-----------:|-----------:|------------:|------------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    85.02 ns |   134.73 ns |   7.385 ns |   4.264 ns |    80.30 ns |    93.53 ns | 11,762,258.9 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |   199.04 ns |    15.72 ns |   0.862 ns |   0.497 ns |   198.08 ns |   199.74 ns |  5,024,065.5 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   215.25 ns |    86.85 ns |   4.761 ns |   2.748 ns |   211.65 ns |   220.65 ns |  4,645,770.8 | 0.0470 |      - |     296 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |   251.93 ns |    83.32 ns |   4.567 ns |   2.637 ns |   247.39 ns |   256.52 ns |  3,969,400.7 |      - |      - |         - |
|  ReplaceRegexBuilder | Rando(...)tween [39] |   345.99 ns | 1,359.99 ns |  74.546 ns |  43.039 ns |   261.97 ns |   404.22 ns |  2,890,295.6 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] | 3,384.13 ns |   470.19 ns |  25.773 ns |  14.880 ns | 3,359.34 ns | 3,410.78 ns |    295,497.0 | 1.5030 | 0.0076 |    9456 B |
|        ReplaceString |  ****(...)**** [500] | 3,508.60 ns | 2,306.67 ns | 126.436 ns |  72.998 ns | 3,415.71 ns | 3,652.59 ns |    285,013.8 | 0.0038 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 6,654.20 ns | 4,041.92 ns | 221.551 ns | 127.913 ns | 6,399.23 ns | 6,799.82 ns |    150,281.0 | 2.3422 | 0.0305 |   14712 B |
|        ReplaceString | ****(...)**** [1000] | 6,736.89 ns | 1,796.74 ns |  98.485 ns |  56.861 ns | 6,663.03 ns | 6,848.70 ns |    148,436.5 |      - |      - |      24 B |
