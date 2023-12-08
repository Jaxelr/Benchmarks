# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    272.9 ns |   1,899.0 ns |   104.09 ns |    60.10 ns |    202.6 ns |    392.4 ns | 3,664,962.7 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    377.5 ns |   1,676.5 ns |    91.89 ns |    53.05 ns |    274.9 ns |    452.3 ns | 2,649,314.2 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    394.1 ns |     331.8 ns |    18.19 ns |    10.50 ns |    378.8 ns |    414.2 ns | 2,537,519.6 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    457.9 ns |     817.9 ns |    44.83 ns |    25.88 ns |    412.4 ns |    502.1 ns | 2,183,665.6 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 23,149.9 ns |  14,790.6 ns |   810.72 ns |   468.07 ns | 22,219.9 ns | 23,707.3 ns |    43,196.7 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 28,134.2 ns |  95,439.0 ns | 5,231.33 ns | 3,020.31 ns | 22,109.2 ns | 31,522.4 ns |    35,543.9 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 77,388.2 ns | 110,482.8 ns | 6,055.94 ns | 3,496.40 ns | 70,418.2 ns | 81,361.8 ns |    12,921.9 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 78,206.0 ns |  75,066.6 ns | 4,114.65 ns | 2,375.60 ns | 74,020.5 ns | 82,245.9 ns |    12,786.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
