# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    221.2 ns |     16.69 ns |     0.91 ns |     0.53 ns |    220.5 ns |    222.2 ns | 4,520,842.8 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    222.3 ns |      9.91 ns |     0.54 ns |     0.31 ns |    221.7 ns |    222.8 ns | 4,498,633.6 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    336.1 ns |     51.14 ns |     2.80 ns |     1.62 ns |    334.4 ns |    339.4 ns | 2,975,019.2 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    340.2 ns |     29.47 ns |     1.62 ns |     0.93 ns |    338.5 ns |    341.7 ns | 2,939,710.0 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 21,403.5 ns |    566.83 ns |    31.07 ns |    17.94 ns | 21,378.4 ns | 21,438.3 ns |    46,721.3 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 21,658.3 ns |  1,113.31 ns |    61.02 ns |    35.23 ns | 21,609.7 ns | 21,726.8 ns |    46,171.7 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 62,302.6 ns | 14,035.20 ns |   769.32 ns |   444.17 ns | 61,414.3 ns | 62,753.8 ns |    16,050.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 63,941.8 ns | 61,960.09 ns | 3,396.24 ns | 1,960.82 ns | 61,233.5 ns | 67,752.2 ns |    15,639.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
