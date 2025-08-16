# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    199.1 ns |      8.49 ns |     0.47 ns |   0.27 ns |    198.5 ns |    199.4 ns | 5,023,326.7 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    200.0 ns |      8.64 ns |     0.47 ns |   0.27 ns |    199.5 ns |    200.4 ns | 5,001,118.0 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    298.0 ns |     81.08 ns |     4.44 ns |   2.57 ns |    293.1 ns |    301.8 ns | 3,355,994.2 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    298.6 ns |      5.42 ns |     0.30 ns |   0.17 ns |    298.3 ns |    298.9 ns | 3,348,755.2 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 19,607.8 ns |  1,817.65 ns |    99.63 ns |  57.52 ns | 19,525.9 ns | 19,718.7 ns |    51,000.2 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 20,565.9 ns | 17,605.33 ns |   965.01 ns | 557.15 ns | 19,739.1 ns | 21,626.3 ns |    48,624.1 | 18.8599 |       - |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 60,073.9 ns |  3,916.31 ns |   214.67 ns | 123.94 ns | 59,840.8 ns | 60,263.5 ns |    16,646.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 60,270.7 ns | 25,621.41 ns | 1,404.40 ns | 810.83 ns | 59,014.5 ns | 61,787.0 ns |    16,591.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
