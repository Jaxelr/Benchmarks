# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     81.02 ns |    14.16 ns |  0.776 ns |  0.448 ns |     80.13 ns |     81.57 ns | 12,343,019.9 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    129.84 ns |    52.86 ns |  2.898 ns |  1.673 ns |    127.73 ns |    133.14 ns |  7,701,672.2 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    145.83 ns |    40.13 ns |  2.200 ns |  1.270 ns |    143.35 ns |    147.53 ns |  6,857,171.6 | 0.0591 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    151.14 ns |    44.36 ns |  2.432 ns |  1.404 ns |    149.70 ns |    153.95 ns |  6,616,388.5 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    196.22 ns |    16.82 ns |  0.922 ns |  0.532 ns |    195.48 ns |    197.25 ns |  5,096,410.9 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  5,867.98 ns |   578.25 ns | 31.696 ns | 18.299 ns |  5,833.26 ns |  5,895.36 ns |    170,416.3 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,298.26 ns |   858.87 ns | 47.077 ns | 27.180 ns |  7,257.89 ns |  7,349.97 ns |    137,018.9 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 12,132.07 ns | 1,684.11 ns | 92.312 ns | 53.296 ns | 12,036.34 ns | 12,220.54 ns |     82,426.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 14,899.30 ns | 1,100.75 ns | 60.336 ns | 34.835 ns | 14,862.72 ns | 14,968.94 ns |     67,117.3 | 0.4883 |    2072 B |
