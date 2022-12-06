# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |       Error |     StdDev |     StdErr |         Min |          Max |         Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |------------:|------------:|-----------:|-----------:|------------:|-------------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    75.07 ns |    31.88 ns |   1.747 ns |   1.009 ns |    74.03 ns |     77.08 ns | 13,321,594.1 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder | Rando(...)tween [39] |   190.07 ns |    99.06 ns |   5.430 ns |   3.135 ns |   186.23 ns |    196.29 ns |  5,261,084.9 |      - |      - |         - |
|  ReplaceRegexBuilder |  ****(...)**** [500] |   212.33 ns |    87.51 ns |   4.797 ns |   2.769 ns |   207.71 ns |    217.29 ns |  4,709,615.3 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   213.56 ns |    56.20 ns |   3.081 ns |   1.779 ns |   210.50 ns |    216.66 ns |  4,682,560.7 | 0.0393 |      - |     248 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |   227.04 ns |    55.75 ns |   3.056 ns |   1.764 ns |   224.41 ns |    230.39 ns |  4,404,554.1 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] | 3,687.70 ns | 4,773.55 ns | 261.655 ns | 151.066 ns | 3,385.86 ns |  3,850.06 ns |    271,171.4 | 1.4992 | 0.0038 |    9408 B |
|        ReplaceString |  ****(...)**** [500] | 4,963.16 ns | 2,269.46 ns | 124.397 ns |  71.820 ns | 4,832.60 ns |  5,080.31 ns |    201,484.4 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 5,936.10 ns | 1,801.66 ns |  98.755 ns |  57.016 ns | 5,859.76 ns |  6,047.63 ns |    168,460.9 | 2.3346 | 0.0229 |   14664 B |
|        ReplaceString | ****(...)**** [1000] | 9,895.15 ns | 2,019.51 ns | 110.696 ns |  63.910 ns | 9,799.75 ns | 10,016.52 ns |    101,059.7 |      - |      - |      24 B |
