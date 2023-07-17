# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                    Method |  Size |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |        Op/s |    Gen0 |    Gen1 |    Gen2 | Allocated |
|-------------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem |   100 |     499.7 ns |   1,005.0 ns |     55.09 ns |     31.80 ns |     464.5 ns |     563.2 ns | 2,001,256.9 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem |   100 |     528.2 ns |   1,793.4 ns |     98.30 ns |     56.76 ns |     455.0 ns |     639.9 ns | 1,893,130.2 |  0.1364 |       - |       - |     856 B |
|     AllocateListLargeItem |   100 |     795.3 ns |   2,978.7 ns |    163.27 ns |     94.27 ns |     686.0 ns |     983.0 ns | 1,257,314.3 |  0.3490 |  0.0010 |       - |    2192 B |
|     AllocateListSmallItem |   100 |   1,076.0 ns |   3,146.3 ns |    172.46 ns |     99.57 ns |     926.8 ns |   1,264.8 ns |   929,340.1 |  0.3490 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 |  42,227.5 ns |  43,027.1 ns |  2,358.46 ns |  1,361.66 ns |  39,697.3 ns |  44,364.9 ns |    23,681.2 | 12.6343 |  2.0752 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 |  59,483.0 ns | 327,518.4 ns | 17,952.39 ns | 10,364.82 ns |  44,905.5 ns |  79,535.4 ns |    16,811.5 | 12.6343 |  2.0752 |       - |   80056 B |
|     AllocateListSmallItem | 10000 | 126,972.0 ns | 440,091.4 ns | 24,122.89 ns | 13,927.36 ns | 111,884.2 ns | 154,793.6 ns |     7,875.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
|     AllocateListLargeItem | 10000 | 128,016.8 ns | 196,312.3 ns | 10,760.54 ns |  6,212.60 ns | 121,280.3 ns | 140,426.8 ns |     7,811.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
