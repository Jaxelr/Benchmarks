# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.304
  [Host]   : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                    Method |  Size |        Mean |       Error |      StdDev |    StdErr |         Min |         Max |        Op/s |    Gen0 |    Gen1 |    Gen2 | Allocated |
|-------------------------- |------ |------------:|------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem |   100 |    298.9 ns |    260.7 ns |    14.29 ns |   8.25 ns |    290.6 ns |    315.4 ns | 3,345,262.4 |  0.1364 |       - |       - |     856 B |
| PreprovisionListSmallItem |   100 |    320.3 ns |    293.4 ns |    16.08 ns |   9.28 ns |    303.4 ns |    335.4 ns | 3,122,303.6 |  0.1364 |       - |       - |     856 B |
|     AllocateListLargeItem |   100 |    481.4 ns |    260.7 ns |    14.29 ns |   8.25 ns |    468.9 ns |    497.0 ns | 2,077,258.6 |  0.3490 |  0.0010 |       - |    2192 B |
|     AllocateListSmallItem |   100 |    494.3 ns |    412.8 ns |    22.63 ns |  13.06 ns |    480.6 ns |    520.4 ns | 2,023,086.1 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 25,910.3 ns |  1,599.7 ns |    87.69 ns |  50.63 ns | 25,814.0 ns | 25,985.6 ns |    38,594.7 | 12.6343 |  2.1057 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 27,095.8 ns |  8,107.7 ns |   444.41 ns | 256.58 ns | 26,595.2 ns | 27,443.8 ns |    36,906.1 | 12.6343 |  2.1057 |       - |   80056 B |
|     AllocateListSmallItem | 10000 | 72,914.1 ns | 15,692.4 ns |   860.15 ns | 496.61 ns | 71,924.8 ns | 73,485.5 ns |    13,714.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
|     AllocateListLargeItem | 10000 | 73,114.5 ns | 27,242.5 ns | 1,493.25 ns | 862.13 ns | 71,553.9 ns | 74,529.8 ns |    13,677.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |

