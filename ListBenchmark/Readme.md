# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    270.3 ns |     59.21 ns |     3.25 ns |     1.87 ns |    266.7 ns |    272.8 ns | 3,698,986.7 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    292.8 ns |     26.57 ns |     1.46 ns |     0.84 ns |    291.1 ns |    293.7 ns | 3,415,848.3 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    394.4 ns |     15.61 ns |     0.86 ns |     0.49 ns |    393.7 ns |    395.3 ns | 2,535,548.3 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    413.0 ns |     99.93 ns |     5.48 ns |     3.16 ns |    407.7 ns |    418.7 ns | 2,421,488.9 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 26,468.0 ns |  4,176.04 ns |   228.90 ns |   132.16 ns | 26,230.8 ns | 26,687.6 ns |    37,781.4 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 28,045.8 ns |  4,552.22 ns |   249.52 ns |   144.06 ns | 27,758.8 ns | 28,211.1 ns |    35,655.9 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 81,765.0 ns | 13,295.11 ns |   728.75 ns |   420.74 ns | 81,098.7 ns | 82,543.2 ns |    12,230.2 | 86.0596 | 86.0596 | 39.6729 |  262469 B |
| AllocateListLargeItem     | 10000 | 82,940.5 ns | 38,428.08 ns | 2,106.37 ns | 1,216.11 ns | 81,710.6 ns | 85,372.7 ns |    12,056.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
