# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    199.1 ns |     21.73 ns |     1.19 ns |     0.69 ns |    197.7 ns |    200.0 ns | 5,022,830.6 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListSmallItem | 100   |    209.0 ns |    104.35 ns |     5.72 ns |     3.30 ns |    202.5 ns |    213.2 ns | 4,785,036.7 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    332.3 ns |     25.32 ns |     1.39 ns |     0.80 ns |    331.1 ns |    333.8 ns | 3,009,540.3 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    361.3 ns |    416.39 ns |    22.82 ns |    13.18 ns |    344.7 ns |    387.3 ns | 2,768,099.1 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 18,528.6 ns |  2,461.77 ns |   134.94 ns |    77.91 ns | 18,426.7 ns | 18,681.6 ns |    53,970.6 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 18,567.8 ns |  2,867.56 ns |   157.18 ns |    90.75 ns | 18,437.3 ns | 18,742.3 ns |    53,856.6 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 65,001.7 ns | 35,555.44 ns | 1,948.91 ns | 1,125.21 ns | 62,759.4 ns | 66,287.8 ns |    15,384.2 | 41.6260 | 41.6260 | 41.6260 |  262472 B |
| AllocateListLargeItem     | 10000 | 65,925.0 ns | 18,506.89 ns | 1,014.43 ns |   585.68 ns | 64,886.4 ns | 66,913.4 ns |    15,168.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
