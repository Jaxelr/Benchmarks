# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]   : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |        Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------------------- |------------:|-------------:|------------:|-------:|------:|------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    183.2 ns |     59.59 ns |     3.27 ns | 0.0610 |     - |     - |      96 B |
| ReplaceStringBuilder | Rando(...)tween [39] |    529.8 ns |     28.08 ns |     1.54 ns | 0.1879 |     - |     - |     296 B |
|  ReplaceRegexBuilder | Rando(...)tween [39] |    893.4 ns |    711.80 ns |    39.02 ns | 0.3300 |     - |     - |     520 B |
|  ReplaceRegexBuilder |  ****(...)**** [500] |  2,460.4 ns |  1,236.34 ns |    67.77 ns | 0.3242 |     - |     - |     520 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |  4,277.0 ns |  1,747.70 ns |    95.80 ns | 0.3204 |     - |     - |     520 B |
|        ReplaceString |  ****(...)**** [500] |  7,674.2 ns |  9,436.64 ns |   517.25 ns | 0.0153 |     - |     - |      24 B |
| ReplaceStringBuilder |  ****(...)**** [500] | 11,632.9 ns |    455.93 ns |    24.99 ns | 6.0120 |     - |     - |    9456 B |
|        ReplaceString | ****(...)**** [1000] | 14,135.9 ns |  2,343.73 ns |   128.47 ns | 0.0153 |     - |     - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 22,724.7 ns | 21,122.30 ns | 1,157.78 ns | 9.3384 |     - |     - |   14712 B |
