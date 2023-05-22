# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1702)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |         Mean |       Error |     StdDev |     StdErr |          Min |          Max |         Op/s |   Gen0 |   Gen1 | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |     90.74 ns |   174.32 ns |   9.555 ns |   5.517 ns |     80.53 ns |     99.47 ns | 11,020,361.9 | 0.0153 |      - |      96 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |    251.16 ns |   211.28 ns |  11.581 ns |   6.686 ns |    242.04 ns |    264.19 ns |  3,981,564.5 |      - |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    251.43 ns |   150.91 ns |   8.272 ns |   4.776 ns |    243.97 ns |    260.33 ns |  3,977,272.3 | 0.0393 |      - |     248 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |    276.98 ns |   142.25 ns |   7.797 ns |   4.502 ns |    269.95 ns |    285.37 ns |  3,610,363.9 |      - |      - |         - |
|  ReplaceRegexBuilder | Rando(...)tween [39] |    289.70 ns |   698.70 ns |  38.298 ns |  22.111 ns |    263.42 ns |    333.65 ns |  3,451,793.1 |      - |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] |  3,723.74 ns | 3,893.07 ns | 213.392 ns | 123.202 ns |  3,477.76 ns |  3,859.27 ns |    268,547.5 | 1.4954 |      - |    9408 B |
|        ReplaceString |  ****(...)**** [500] |  4,958.32 ns | 1,479.25 ns |  81.082 ns |  46.813 ns |  4,869.44 ns |  5,028.24 ns |    201,681.1 |      - |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] |  7,126.28 ns | 5,290.46 ns | 289.988 ns | 167.425 ns |  6,797.09 ns |  7,343.98 ns |    140,325.6 | 2.3346 | 0.0153 |   14664 B |
|        ReplaceString | ****(...)**** [1000] | 11,410.09 ns | 8,299.68 ns | 454.933 ns | 262.656 ns | 11,081.62 ns | 11,929.35 ns |     87,641.7 |      - |      - |      24 B |
