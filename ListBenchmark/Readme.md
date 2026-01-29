# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    234.4 ns |     21.05 ns |     1.15 ns |   0.67 ns |    233.2 ns |    235.5 ns | 4,266,011.0 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    240.2 ns |    134.33 ns |     7.36 ns |   4.25 ns |    233.9 ns |    248.3 ns | 4,162,486.4 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    371.4 ns |    451.74 ns |    24.76 ns |  14.30 ns |    355.5 ns |    400.0 ns | 2,692,281.3 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    373.2 ns |     30.68 ns |     1.68 ns |   0.97 ns |    371.4 ns |    374.7 ns | 2,679,542.0 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 21,939.6 ns |    761.29 ns |    41.73 ns |  24.09 ns | 21,911.9 ns | 21,987.6 ns |    45,579.7 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 22,772.7 ns | 17,636.56 ns |   966.72 ns | 558.14 ns | 22,132.9 ns | 23,884.7 ns |    43,912.3 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 63,619.6 ns | 21,154.56 ns | 1,159.55 ns | 669.47 ns | 62,294.0 ns | 64,445.5 ns |    15,718.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 65,770.1 ns | 19,235.82 ns | 1,054.38 ns | 608.75 ns | 64,834.5 ns | 66,912.6 ns |    15,204.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
