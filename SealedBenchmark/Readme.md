# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method |       Mean |      Error |    StdDev |    StdErr |        Min |        Max |             Op/s |   Gen0 | Allocated |
|------------------ |-----------:|-----------:|----------:|----------:|-----------:|-----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 10.9160 ns | 16.9630 ns | 0.9298 ns | 0.5368 ns | 10.1259 ns | 11.9406 ns |     91,608,751.2 | 0.0038 |      24 B |
|   Open_AddToArray | 17.2954 ns |  8.7947 ns | 0.4821 ns | 0.2783 ns | 16.7419 ns | 17.6230 ns |     57,818,787.9 | 0.0038 |      24 B |
|                   |            |            |           |           |            |            |                  |        |           |
|    Sealed_Casting |  1.0045 ns |  2.8580 ns | 0.1567 ns | 0.0904 ns |  0.8791 ns |  1.1801 ns |    995,556,768.7 |      - |         - |
|      Open_Casting |  8.1016 ns | 12.0904 ns | 0.6627 ns | 0.3826 ns |  7.5352 ns |  8.8305 ns |    123,431,721.1 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
|  Sealed_IntMethod |  0.0730 ns |  1.3782 ns | 0.0755 ns | 0.0436 ns |  0.0000 ns |  0.1509 ns | 13,690,890,062.3 |      - |         - |
|    Open_IntMethod |  1.1829 ns |  1.0529 ns | 0.0577 ns | 0.0333 ns |  1.1168 ns |  1.2232 ns |    845,365,890.5 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
|     Open_ToString | 27.0658 ns | 12.9213 ns | 0.7083 ns | 0.4089 ns | 26.6412 ns | 27.8835 ns |     36,946,958.4 |      - |         - |
|   Sealed_ToString | 30.1410 ns | 27.3333 ns | 1.4982 ns | 0.8650 ns | 29.2502 ns | 31.8707 ns |     33,177,447.7 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
| Sealed_VoidMethod |  0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |         Infinity |      - |         - |
|   Open_VoidMethod |  1.6113 ns |  9.9558 ns | 0.5457 ns | 0.3151 ns |  0.9994 ns |  2.0475 ns |    620,613,521.7 |      - |         - |
