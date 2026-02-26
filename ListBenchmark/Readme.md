# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    231.1 ns |     42.35 ns |     2.32 ns |     1.34 ns |    228.8 ns |    233.4 ns | 4,326,737.9 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    259.5 ns |    124.96 ns |     6.85 ns |     3.95 ns |    252.0 ns |    265.5 ns | 3,854,156.2 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    339.9 ns |    101.81 ns |     5.58 ns |     3.22 ns |    334.9 ns |    345.9 ns | 2,941,920.6 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    349.1 ns |     53.87 ns |     2.95 ns |     1.70 ns |    346.7 ns |    352.4 ns | 2,864,895.0 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 23,222.2 ns |  9,101.75 ns |   498.90 ns |   288.04 ns | 22,781.5 ns | 23,763.9 ns |    43,062.2 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 23,461.7 ns |  1,639.07 ns |    89.84 ns |    51.87 ns | 23,358.8 ns | 23,524.3 ns |    42,622.6 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 65,337.2 ns | 28,953.73 ns | 1,587.05 ns |   916.28 ns | 63,782.0 ns | 66,954.3 ns |    15,305.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 67,018.2 ns | 43,633.34 ns | 2,391.69 ns | 1,380.84 ns | 64,548.2 ns | 69,323.0 ns |    14,921.3 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
