# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.201
  [Host]   : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  ShortRun : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |                value |        Mean |        Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |        Op/s |  Gen 0 | Allocated |
|--------------------- |--------------------- |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|------------:|-------:|----------:|
|        ReplaceString | Rando(...)tween [39] |    176.9 ns |    123.63 ns |   6.78 ns |   3.91 ns |    169.6 ns |    173.8 ns |    178.1 ns |    180.5 ns |    182.9 ns | 5,654,034.6 | 0.0229 |      96 B |
|  ReplaceRegexBuilder | Rando(...)tween [39] |    415.7 ns |    304.40 ns |  16.69 ns |   9.63 ns |    397.6 ns |    408.3 ns |    419.0 ns |    424.7 ns |    430.5 ns | 2,405,672.7 |      - |         - |
|  ReplaceRegexBuilder |  ****(...)**** [500] |    438.2 ns |    933.51 ns |  51.17 ns |  29.54 ns |    406.3 ns |    408.7 ns |    411.0 ns |    454.1 ns |    497.2 ns | 2,282,191.9 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    452.8 ns |     77.40 ns |   4.24 ns |   2.45 ns |    448.3 ns |    450.9 ns |    453.5 ns |    455.1 ns |    456.7 ns | 2,208,351.1 | 0.0706 |     296 B |
|  ReplaceRegexBuilder | ****(...)**** [1000] |    531.9 ns |    846.16 ns |  46.38 ns |  26.78 ns |    487.3 ns |    507.9 ns |    528.6 ns |    554.2 ns |    579.8 ns | 1,880,115.8 |      - |         - |
| ReplaceStringBuilder |  ****(...)**** [500] |  8,003.2 ns |  1,384.09 ns |  75.87 ns |  43.80 ns |  7,915.9 ns |  7,978.5 ns |  8,041.0 ns |  8,046.9 ns |  8,052.8 ns |   124,949.3 | 2.2583 |   9,456 B |
|        ReplaceString |  ****(...)**** [500] |  8,577.8 ns | 11,358.18 ns | 622.58 ns | 359.45 ns |  7,974.1 ns |  8,257.8 ns |  8,541.6 ns |  8,879.6 ns |  9,217.7 ns |   116,580.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 16,014.1 ns | 11,103.77 ns | 608.63 ns | 351.40 ns | 15,446.6 ns | 15,692.7 ns | 15,938.9 ns | 16,297.9 ns | 16,656.9 ns |    62,444.9 | 3.5095 |  14,712 B |
|        ReplaceString | ****(...)**** [1000] | 16,678.5 ns | 15,070.81 ns | 826.08 ns | 476.94 ns | 16,000.2 ns | 16,218.5 ns | 16,436.7 ns | 17,017.6 ns | 17,598.5 ns |    59,957.5 |      - |      24 B |
