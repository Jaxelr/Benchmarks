# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error       | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    216.5 ns |     7.23 ns |   0.40 ns |   0.23 ns |    216.1 ns |    216.8 ns | 4,618,800.4 |  0.2046 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    217.2 ns |    23.46 ns |   1.29 ns |   0.74 ns |    216.1 ns |    218.6 ns | 4,603,155.5 |  0.2046 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    324.7 ns |    26.19 ns |   1.44 ns |   0.83 ns |    323.4 ns |    326.2 ns | 3,079,707.1 |  0.5240 |       - |       - |    2192 B |
| AllocateListSmallItem     | 100   |    331.9 ns |    28.66 ns |   1.57 ns |   0.91 ns |    330.3 ns |    333.4 ns | 3,012,752.9 |  0.5240 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 20,971.4 ns |   537.50 ns |  29.46 ns |  17.01 ns | 20,945.1 ns | 21,003.2 ns |    47,684.0 | 18.8599 |       - |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 20,992.5 ns | 1,177.39 ns |  64.54 ns |  37.26 ns | 20,954.9 ns | 21,067.1 ns |    47,636.0 | 18.8599 |       - |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 59,556.4 ns | 4,394.36 ns | 240.87 ns | 139.07 ns | 59,290.6 ns | 59,760.1 ns |    16,790.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 60,214.6 ns | 6,069.94 ns | 332.71 ns | 192.09 ns | 59,933.3 ns | 60,581.8 ns |    16,607.3 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
