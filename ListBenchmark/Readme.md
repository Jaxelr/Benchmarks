# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    226.4 ns |     21.37 ns |   1.17 ns |   0.68 ns |    225.4 ns |    227.7 ns | 4,417,086.8 |  0.2046 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    227.5 ns |     13.44 ns |   0.74 ns |   0.43 ns |    226.7 ns |    228.1 ns | 4,395,097.9 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    346.1 ns |    221.39 ns |  12.13 ns |   7.01 ns |    338.2 ns |    360.1 ns | 2,888,944.7 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    347.0 ns |     20.36 ns |   1.12 ns |   0.64 ns |    345.7 ns |    347.9 ns | 2,881,864.4 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 21,830.5 ns |  1,427.85 ns |  78.27 ns |  45.19 ns | 21,750.5 ns | 21,907.0 ns |    45,807.5 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 22,058.5 ns |  4,021.42 ns | 220.43 ns | 127.26 ns | 21,830.3 ns | 22,270.2 ns |    45,333.9 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 62,591.1 ns |  3,356.60 ns | 183.99 ns | 106.22 ns | 62,401.8 ns | 62,769.3 ns |    15,976.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 63,247.5 ns | 15,705.71 ns | 860.88 ns | 497.03 ns | 62,477.4 ns | 64,176.9 ns |    15,810.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
