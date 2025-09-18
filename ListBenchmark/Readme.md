# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    250.1 ns |     49.01 ns |     2.69 ns |   1.55 ns |    248.1 ns |    253.1 ns | 3,998,863.5 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    257.3 ns |     81.47 ns |     4.47 ns |   2.58 ns |    253.7 ns |    262.3 ns | 3,887,034.4 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    373.6 ns |     80.66 ns |     4.42 ns |   2.55 ns |    370.2 ns |    378.6 ns | 2,676,434.6 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    375.3 ns |    162.16 ns |     8.89 ns |   5.13 ns |    369.5 ns |    385.5 ns | 2,664,805.2 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 24,220.4 ns |  1,578.86 ns |    86.54 ns |  49.97 ns | 24,168.7 ns | 24,320.3 ns |    41,287.6 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 25,083.4 ns | 25,173.93 ns | 1,379.87 ns | 796.67 ns | 24,255.8 ns | 26,676.3 ns |    39,867.0 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 71,544.9 ns | 24,743.46 ns | 1,356.27 ns | 783.04 ns | 70,381.4 ns | 73,034.5 ns |    13,977.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 72,255.0 ns | 11,839.55 ns |   648.97 ns | 374.68 ns | 71,509.8 ns | 72,695.7 ns |    13,839.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
