# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    242.8 ns |    102.3 ns |     5.61 ns |     3.24 ns |    236.6 ns |    247.6 ns | 4,119,027.0 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    250.2 ns |    178.6 ns |     9.79 ns |     5.65 ns |    239.0 ns |    256.6 ns | 3,996,082.5 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    366.6 ns |    212.6 ns |    11.65 ns |     6.73 ns |    353.2 ns |    374.5 ns | 2,727,611.0 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    370.8 ns |    236.2 ns |    12.95 ns |     7.47 ns |    357.6 ns |    383.5 ns | 2,696,906.4 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 22,982.3 ns |  6,371.7 ns |   349.25 ns |   201.64 ns | 22,608.4 ns | 23,300.0 ns |    43,511.7 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 23,861.7 ns |  7,320.4 ns |   401.26 ns |   231.67 ns | 23,621.8 ns | 24,324.9 ns |    41,908.2 | 18.8599 |       - |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 70,765.6 ns | 92,913.4 ns | 5,092.90 ns | 2,940.39 ns | 64,891.8 ns | 73,950.9 ns |    14,131.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 74,923.7 ns | 90,004.2 ns | 4,933.44 ns | 2,848.32 ns | 69,340.2 ns | 78,693.9 ns |    13,346.9 | 41.6260 | 41.6260 | 41.6260 |  262471 B |
