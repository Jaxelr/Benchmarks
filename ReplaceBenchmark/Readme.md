# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.403
  [Host]   : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error      | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-----------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     60.68 ns |   5.235 ns |  0.287 ns |  0.166 ns |     60.40 ns |     60.98 ns | 16,479,677.6 | 0.0229 |      96 B |
| ReplaceStringBuilder | Rando(...)tween [39] |    105.38 ns |  35.876 ns |  1.966 ns |  1.135 ns |    104.12 ns |    107.65 ns |  9,489,516.5 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    106.03 ns |  36.655 ns |  2.009 ns |  1.160 ns |    103.84 ns |    107.80 ns |  9,431,617.2 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    114.46 ns |   1.319 ns |  0.072 ns |  0.042 ns |    114.42 ns |    114.55 ns |  8,736,504.3 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    147.23 ns |  75.144 ns |  4.119 ns |  2.378 ns |    144.24 ns |    151.93 ns |  6,791,878.6 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,863.44 ns | 453.852 ns | 24.877 ns | 14.363 ns |  4,835.32 ns |  4,882.57 ns |    205,615.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,906.18 ns | 149.080 ns |  8.172 ns |  4.718 ns |  5,900.10 ns |  5,915.47 ns |    169,314.3 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,798.53 ns | 360.761 ns | 19.775 ns | 11.417 ns |  9,780.07 ns |  9,819.40 ns |    102,056.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 24,119.09 ns | 598.985 ns | 32.832 ns | 18.956 ns | 24,081.48 ns | 24,142.07 ns |     41,460.9 | 0.4883 |    2072 B |
