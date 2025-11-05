# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error         | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|--------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    235.7 ns |      17.71 ns |     0.97 ns |     0.56 ns |    235.1 ns |    236.8 ns | 4,242,263.1 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    239.3 ns |      76.61 ns |     4.20 ns |     2.42 ns |    234.6 ns |    242.7 ns | 4,179,246.7 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    343.0 ns |      41.55 ns |     2.28 ns |     1.31 ns |    340.9 ns |    345.4 ns | 2,915,307.7 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    350.7 ns |      87.09 ns |     4.77 ns |     2.76 ns |    346.2 ns |    355.7 ns | 2,851,308.4 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 22,461.7 ns |     809.70 ns |    44.38 ns |    25.62 ns | 22,410.6 ns | 22,490.0 ns |    44,520.1 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 22,567.9 ns |  45,563.08 ns | 2,497.47 ns | 1,441.91 ns | 19,737.5 ns | 24,461.8 ns |    44,310.7 | 18.8599 |       - |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 63,781.9 ns |  16,345.42 ns |   895.95 ns |   517.28 ns | 63,207.4 ns | 64,814.3 ns |    15,678.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 66,107.0 ns | 129,850.41 ns | 7,117.54 ns | 4,109.31 ns | 59,920.9 ns | 73,886.0 ns |    15,127.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
