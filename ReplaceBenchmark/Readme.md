# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error        | StdDev     | StdErr     | Min         | Max         | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|-------------:|-----------:|-----------:|------------:|------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |    56.38 ns |    26.724 ns |   1.465 ns |   0.846 ns |    55.00 ns |    57.92 ns | 17,735,712.1 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    90.02 ns |     5.166 ns |   0.283 ns |   0.163 ns |    89.69 ns |    90.21 ns | 11,109,127.6 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   103.37 ns |   127.641 ns |   6.996 ns |   4.039 ns |    98.27 ns |   111.35 ns |  9,673,666.2 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |   115.52 ns |    83.613 ns |   4.583 ns |   2.646 ns |   112.86 ns |   120.81 ns |  8,656,708.9 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |   149.99 ns |    25.098 ns |   1.376 ns |   0.794 ns |   148.96 ns |   151.55 ns |  6,667,267.2 |      - |         - |
| ReplaceString        | ****(...)**** [500]  | 4,323.94 ns | 1,039.440 ns |  56.975 ns |  32.895 ns | 4,281.78 ns | 4,388.76 ns |    231,270.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 4,612.76 ns |   133.195 ns |   7.301 ns |   4.215 ns | 4,604.75 ns | 4,619.03 ns |    216,789.8 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 8,582.03 ns | 2,236.955 ns | 122.615 ns |  70.792 ns | 8,441.97 ns | 8,670.00 ns |    116,522.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 9,447.97 ns | 3,663.900 ns | 200.831 ns | 115.950 ns | 9,289.41 ns | 9,673.80 ns |    105,842.8 | 0.4883 |    2072 B |
