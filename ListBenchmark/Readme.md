# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7462)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method                    | Size  | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    206.6 ns |     32.37 ns |   1.77 ns |   1.02 ns |    205.3 ns |    208.6 ns | 4,841,044.7 |  0.2046 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    210.6 ns |    121.49 ns |   6.66 ns |   3.84 ns |    206.5 ns |    218.3 ns | 4,747,565.5 |  0.2046 |       - |       - |     856 B |
| AllocateListSmallItem     | 100   |    340.2 ns |     66.28 ns |   3.63 ns |   2.10 ns |    336.5 ns |    343.7 ns | 2,939,599.5 |  0.5240 |       - |       - |    2192 B |
| AllocateListLargeItem     | 100   |    350.3 ns |     24.16 ns |   1.32 ns |   0.76 ns |    348.8 ns |    351.3 ns | 2,855,062.6 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 20,050.1 ns |    371.75 ns |  20.38 ns |  11.76 ns | 20,026.7 ns | 20,064.2 ns |    49,875.1 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 20,052.7 ns |    937.90 ns |  51.41 ns |  29.68 ns | 20,001.6 ns | 20,104.4 ns |    49,868.7 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 56,032.3 ns | 17,989.61 ns | 986.07 ns | 569.31 ns | 55,150.0 ns | 57,096.7 ns |    17,846.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 60,328.5 ns | 12,887.88 ns | 706.43 ns | 407.86 ns | 59,858.0 ns | 61,140.8 ns |    16,575.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
