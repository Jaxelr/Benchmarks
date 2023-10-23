# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    332.8 ns |    576.1 ns |    31.58 ns |    18.23 ns |    306.1 ns |    367.6 ns | 3,005,186.0 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |    385.9 ns |    758.2 ns |    41.56 ns |    24.00 ns |    344.3 ns |    427.4 ns | 2,591,528.5 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    451.2 ns |    157.1 ns |     8.61 ns |     4.97 ns |    444.6 ns |    461.0 ns | 2,216,216.6 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    527.5 ns |    753.0 ns |    41.28 ns |    23.83 ns |    481.0 ns |    559.9 ns | 1,895,701.3 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 28,556.8 ns |  2,638.5 ns |   144.63 ns |    83.50 ns | 28,390.2 ns | 28,650.4 ns |    35,017.9 | 12.6343 |  2.1057 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 28,735.1 ns |  5,863.9 ns |   321.42 ns |   185.57 ns | 28,441.2 ns | 29,078.3 ns |    34,800.6 | 12.6343 |  2.0752 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 78,967.2 ns | 22,500.3 ns | 1,233.32 ns |   712.06 ns | 77,554.5 ns | 79,829.7 ns |    12,663.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 83,728.1 ns | 64,019.2 ns | 3,509.11 ns | 2,025.98 ns | 80,289.1 ns | 87,303.3 ns |    11,943.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
