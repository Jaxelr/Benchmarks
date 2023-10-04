# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2361/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                    Method |  Size |         Mean |        Error |       StdDev |      StdErr |          Min |          Max |        Op/s |    Gen0 |    Gen1 |    Gen2 | Allocated |
|-------------------------- |------ |-------------:|-------------:|-------------:|------------:|-------------:|-------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem |   100 |     448.1 ns |     155.5 ns |      8.52 ns |     4.92 ns |     441.8 ns |     457.8 ns | 2,231,834.9 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem |   100 |     558.3 ns |   1,480.8 ns |     81.17 ns |    46.86 ns |     490.9 ns |     648.4 ns | 1,791,072.1 |  0.1364 |       - |       - |     856 B |
|     AllocateListSmallItem |   100 |     747.2 ns |   1,244.8 ns |     68.23 ns |    39.39 ns |     684.7 ns |     820.0 ns | 1,338,363.8 |  0.3490 |       - |       - |    2192 B |
|     AllocateListLargeItem |   100 |     801.9 ns |   2,471.9 ns |    135.49 ns |    78.23 ns |     648.6 ns |     905.6 ns | 1,247,029.6 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 |  37,406.3 ns |  17,276.1 ns |    946.96 ns |   546.73 ns |  36,703.6 ns |  38,483.2 ns |    26,733.4 | 12.6343 |  2.0752 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 |  37,815.2 ns |  25,096.7 ns |  1,375.63 ns |   794.22 ns |  36,794.5 ns |  39,379.6 ns |    26,444.4 | 12.6343 |  2.0752 |       - |   80056 B |
|     AllocateListSmallItem | 10000 | 101,398.8 ns |  30,854.7 ns |  1,691.25 ns |   976.45 ns |  99,658.0 ns | 103,035.8 ns |     9,862.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
|     AllocateListLargeItem | 10000 | 116,119.8 ns | 261,709.9 ns | 14,345.20 ns | 8,282.21 ns | 105,042.9 ns | 132,324.2 ns |     8,611.8 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
