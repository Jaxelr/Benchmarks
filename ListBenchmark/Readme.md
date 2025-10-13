# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6725)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    206.8 ns |     23.68 ns |     1.30 ns |   0.75 ns |    205.4 ns |    207.9 ns | 4,835,376.4 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    212.3 ns |     44.95 ns |     2.46 ns |   1.42 ns |    209.6 ns |    214.4 ns | 4,709,773.1 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    297.2 ns |     42.44 ns |     2.33 ns |   1.34 ns |    294.5 ns |    298.7 ns | 3,364,532.8 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    301.0 ns |      5.09 ns |     0.28 ns |   0.16 ns |    300.7 ns |    301.3 ns | 3,322,803.2 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 20,044.0 ns |  1,684.06 ns |    92.31 ns |  53.29 ns | 19,986.2 ns | 20,150.5 ns |    49,890.1 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 20,136.7 ns |  1,190.46 ns |    65.25 ns |  37.67 ns | 20,062.8 ns | 20,186.4 ns |    49,660.5 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 53,586.6 ns | 30,958.94 ns | 1,696.96 ns | 979.74 ns | 52,408.4 ns | 55,531.6 ns |    18,661.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 59,692.6 ns |  7,808.41 ns |   428.01 ns | 247.11 ns | 59,202.2 ns | 59,991.1 ns |    16,752.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
