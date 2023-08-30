# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                    Method |  Size |        Mean |        Error |      StdDev |      StdErr |         Min |         Max |        Op/s |    Gen0 |    Gen1 |    Gen2 | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem |   100 |    315.6 ns |     129.5 ns |     7.10 ns |     4.10 ns |    307.8 ns |    321.7 ns | 3,168,690.0 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem |   100 |    325.9 ns |     358.6 ns |    19.66 ns |    11.35 ns |    314.5 ns |    348.6 ns | 3,067,975.2 |  0.1364 |       - |       - |     856 B |
|     AllocateListLargeItem |   100 |    484.3 ns |     261.4 ns |    14.33 ns |     8.27 ns |    473.1 ns |    500.4 ns | 2,064,745.0 |  0.3490 |  0.0010 |       - |    2192 B |
|     AllocateListSmallItem |   100 |    567.6 ns |   1,736.5 ns |    95.18 ns |    54.95 ns |    473.7 ns |    664.0 ns | 1,761,672.2 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 31,982.1 ns |  32,924.1 ns | 1,804.68 ns | 1,041.93 ns | 29,935.4 ns | 33,344.9 ns |    31,267.5 | 12.6343 |  2.0752 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 35,873.6 ns |  84,135.1 ns | 4,611.73 ns | 2,662.58 ns | 32,728.1 ns | 41,167.6 ns |    27,875.6 | 12.6343 |  2.1057 |       - |   80056 B |
|     AllocateListLargeItem | 10000 | 78,001.6 ns |  20,771.6 ns | 1,138.56 ns |   657.35 ns | 76,725.7 ns | 78,914.1 ns |    12,820.3 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
|     AllocateListSmallItem | 10000 | 82,828.5 ns | 133,218.2 ns | 7,302.14 ns | 4,215.89 ns | 77,464.1 ns | 91,144.4 ns |    12,073.1 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
