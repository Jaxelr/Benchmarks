# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    216.6 ns |     20.37 ns |     1.12 ns |     0.64 ns |    216.0 ns |    217.9 ns | 4,615,750.7 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    230.4 ns |    172.41 ns |     9.45 ns |     5.46 ns |    224.3 ns |    241.3 ns | 4,340,535.8 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    326.6 ns |     76.13 ns |     4.17 ns |     2.41 ns |    323.2 ns |    331.2 ns | 3,062,195.0 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    333.9 ns |    329.72 ns |    18.07 ns |    10.43 ns |    318.8 ns |    353.9 ns | 2,995,091.9 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 21,305.2 ns |  2,846.74 ns |   156.04 ns |    90.09 ns | 21,146.2 ns | 21,458.1 ns |    46,936.9 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 21,933.8 ns |  6,332.17 ns |   347.09 ns |   200.39 ns | 21,543.8 ns | 22,208.6 ns |    45,591.6 | 18.8599 |       - |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 65,793.1 ns | 40,195.53 ns | 2,203.25 ns | 1,272.05 ns | 63,269.2 ns | 67,331.8 ns |    15,199.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 67,740.6 ns | 79,254.16 ns | 4,344.19 ns | 2,508.12 ns | 65,076.9 ns | 72,753.5 ns |    14,762.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
