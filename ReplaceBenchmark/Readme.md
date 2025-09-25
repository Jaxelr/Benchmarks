# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.6584)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error      | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-----------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     56.30 ns |   4.660 ns |  0.255 ns |  0.147 ns |     56.01 ns |     56.46 ns | 17,761,822.8 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     94.12 ns |   1.773 ns |  0.097 ns |  0.056 ns |     94.01 ns |     94.18 ns | 10,624,585.5 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    104.53 ns |  13.606 ns |  0.746 ns |  0.431 ns |    103.69 ns |    105.10 ns |  9,566,477.9 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    119.13 ns |   5.409 ns |  0.296 ns |  0.171 ns |    118.81 ns |    119.39 ns |  8,394,451.1 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    166.84 ns |  22.964 ns |  1.259 ns |  0.727 ns |    165.76 ns |    168.22 ns |  5,993,801.4 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,884.89 ns |  71.110 ns |  3.898 ns |  2.250 ns |  4,881.13 ns |  4,888.91 ns |    204,713.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,404.21 ns | 221.645 ns | 12.149 ns |  7.014 ns |  5,392.04 ns |  5,416.34 ns |    185,040.9 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,761.86 ns |  55.673 ns |  3.052 ns |  1.762 ns |  9,758.34 ns |  9,763.69 ns |    102,439.5 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 10,796.12 ns | 582.627 ns | 31.936 ns | 18.438 ns | 10,764.57 ns | 10,828.42 ns |     92,625.9 | 0.4883 |    2072 B |
