# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]   : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    226.1 ns |     49.39 ns |   2.71 ns |   1.56 ns |    223.7 ns |    229.0 ns | 4,422,597.9 |  0.2046 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    266.1 ns |    512.25 ns |  28.08 ns |  16.21 ns |    238.5 ns |    294.6 ns | 3,758,245.8 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    335.8 ns |     18.79 ns |   1.03 ns |   0.59 ns |    334.6 ns |    336.4 ns | 2,978,224.4 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    341.6 ns |     90.33 ns |   4.95 ns |   2.86 ns |    338.5 ns |    347.3 ns | 2,927,629.1 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 21,708.6 ns |  1,713.37 ns |  93.92 ns |  54.22 ns | 21,652.7 ns | 21,817.0 ns |    46,064.7 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 21,891.1 ns |  4,639.75 ns | 254.32 ns | 146.83 ns | 21,630.0 ns | 22,138.0 ns |    45,680.8 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 62,803.5 ns | 16,740.71 ns | 917.61 ns | 529.79 ns | 62,052.0 ns | 63,826.1 ns |    15,922.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 65,308.9 ns |  5,256.09 ns | 288.10 ns | 166.34 ns | 65,003.9 ns | 65,576.4 ns |    15,311.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
