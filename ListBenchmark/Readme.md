# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    245.6 ns |     51.72 ns |     2.83 ns |     1.64 ns |    242.5 ns |    248.1 ns | 4,071,612.1 |  0.2046 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    246.3 ns |     39.82 ns |     2.18 ns |     1.26 ns |    243.9 ns |    248.2 ns | 4,060,879.3 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    366.3 ns |     72.78 ns |     3.99 ns |     2.30 ns |    361.8 ns |    369.4 ns | 2,729,700.3 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    395.1 ns |    561.29 ns |    30.77 ns |    17.76 ns |    372.4 ns |    430.1 ns | 2,531,122.3 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 24,212.9 ns |  3,223.43 ns |   176.69 ns |   102.01 ns | 24,068.1 ns | 24,409.8 ns |    41,300.2 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 24,225.1 ns | 13,913.47 ns |   762.64 ns |   440.31 ns | 23,647.2 ns | 25,089.5 ns |    41,279.6 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 61,147.5 ns | 14,827.11 ns |   812.72 ns |   469.23 ns | 60,222.2 ns | 61,745.7 ns |    16,353.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 64,212.1 ns | 40,132.62 ns | 2,199.80 ns | 1,270.06 ns | 62,609.6 ns | 66,720.1 ns |    15,573.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
