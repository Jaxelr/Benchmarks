# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    236.7 ns |     83.44 ns |     4.57 ns |     2.64 ns |    232.6 ns |    241.7 ns | 4,224,201.9 |  0.2046 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    238.0 ns |     75.99 ns |     4.17 ns |     2.40 ns |    233.2 ns |    240.7 ns | 4,201,063.5 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    365.3 ns |     67.81 ns |     3.72 ns |     2.15 ns |    363.0 ns |    369.6 ns | 2,737,250.4 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    373.3 ns |     59.09 ns |     3.24 ns |     1.87 ns |    369.6 ns |    375.3 ns | 2,678,558.4 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 22,011.2 ns |    730.93 ns |    40.06 ns |    23.13 ns | 21,965.4 ns | 22,039.6 ns |    45,431.4 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 22,171.6 ns |  2,117.54 ns |   116.07 ns |    67.01 ns | 22,099.1 ns | 22,305.5 ns |    45,102.8 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 65,119.1 ns | 26,327.43 ns | 1,443.10 ns |   833.17 ns | 63,960.0 ns | 66,735.4 ns |    15,356.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 69,094.2 ns | 34,670.40 ns | 1,900.40 ns | 1,097.20 ns | 66,957.6 ns | 70,595.6 ns |    14,473.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
