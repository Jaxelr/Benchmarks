# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |        Error |       StdDev |       StdErr |         Min |          Q1 |      Median |          Q3 |          Max |         Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |------------:|-------------:|-------------:|-------------:|------------:|------------:|------------:|------------:|-------------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    93.22 ns |     66.44 ns |     3.642 ns |     2.103 ns |    91.05 ns |    91.12 ns |    91.18 ns |    94.30 ns |     97.42 ns | 10,727,619.5 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |   209.92 ns |    101.64 ns |     5.571 ns |     3.217 ns |   205.32 ns |   206.82 ns |   208.32 ns |   212.22 ns |    216.12 ns |  4,763,745.8 |      - |      - |         - |
|  ReplaceRegexBuilder | ****(...)**** [1000] |   262.38 ns |    634.16 ns |    34.760 ns |    20.069 ns |   240.23 ns |   242.35 ns |   244.46 ns |   273.45 ns |    302.44 ns |  3,811,294.8 |      - |      - |         - |
|  ReplaceRegexBuilder | Rando(...)tween [39] |   280.35 ns |    301.37 ns |    16.519 ns |     9.537 ns |   262.66 ns |   272.83 ns |   282.99 ns |   289.19 ns |    295.38 ns |  3,567,029.0 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   298.48 ns |    368.94 ns |    20.223 ns |    11.676 ns |   276.81 ns |   289.31 ns |   301.80 ns |   309.32 ns |    316.84 ns |  3,350,257.0 | 0.0467 |      - |     296 B |
| ReplaceStringBuilder |  ****(...)**** [500] | 3,670.64 ns |  2,369.13 ns |   129.860 ns |    74.975 ns | 3,574.95 ns | 3,596.73 ns | 3,618.50 ns | 3,718.48 ns |  3,818.47 ns |    272,432.1 | 1.5030 | 0.0076 |    9456 B |
|        ReplaceString |  ****(...)**** [500] | 3,707.09 ns |  2,220.64 ns |   121.721 ns |    70.275 ns | 3,634.55 ns | 3,636.83 ns | 3,639.10 ns | 3,743.36 ns |  3,847.62 ns |    269,753.4 | 0.0038 |      - |      24 B |
|        ReplaceString | ****(...)**** [1000] | 7,490.41 ns |  1,646.72 ns |    90.262 ns |    52.113 ns | 7,423.21 ns | 7,439.11 ns | 7,455.00 ns | 7,524.00 ns |  7,593.00 ns |    133,504.1 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 8,924.47 ns | 53,700.05 ns | 2,943.481 ns | 1,699.420 ns | 7,107.80 ns | 7,226.43 ns | 7,345.07 ns | 9,832.81 ns | 12,320.55 ns |    112,051.4 | 2.3422 | 0.0305 |   14712 B |
