# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    230.9 ns |     61.47 ns |     3.37 ns |     1.95 ns |    227.7 ns |    234.4 ns | 4,331,014.6 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    231.9 ns |     42.87 ns |     2.35 ns |     1.36 ns |    229.2 ns |    233.5 ns | 4,311,468.3 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    404.5 ns |    745.66 ns |    40.87 ns |    23.60 ns |    375.5 ns |    451.2 ns | 2,472,416.1 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    418.0 ns |    517.20 ns |    28.35 ns |    16.37 ns |    397.5 ns |    450.4 ns | 2,392,256.7 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 22,933.6 ns |  9,013.26 ns |   494.05 ns |   285.24 ns | 22,363.3 ns | 23,231.9 ns |    43,604.2 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 30,793.3 ns | 21,082.98 ns | 1,155.63 ns |   667.20 ns | 29,467.8 ns | 31,589.5 ns |    32,474.6 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 71,081.1 ns | 30,013.13 ns | 1,645.12 ns |   949.81 ns | 69,896.5 ns | 72,959.4 ns |    14,068.4 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 75,284.3 ns | 62,098.56 ns | 3,403.83 ns | 1,965.20 ns | 71,703.2 ns | 78,477.6 ns |    13,283.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
