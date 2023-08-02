# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method |      Mean |      Error |    StdDev |    StdErr |       Min |       Max |             Op/s |   Gen0 | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 6.8117 ns | 13.1920 ns | 0.7231 ns | 0.4175 ns | 6.3575 ns | 7.6456 ns |    146,806,214.0 | 0.0038 |      24 B |
|   Open_AddToArray | 7.8701 ns |  7.2061 ns | 0.3950 ns | 0.2280 ns | 7.5452 ns | 8.3098 ns |    127,062,864.7 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                  |        |           |
|    Sealed_Casting | 0.6575 ns | 10.9323 ns | 0.5992 ns | 0.3460 ns | 0.0870 ns | 1.2818 ns |  1,520,943,101.9 |      - |         - |
|      Open_Casting | 3.3191 ns | 12.6221 ns | 0.6919 ns | 0.3994 ns | 2.6341 ns | 4.0176 ns |    301,286,850.2 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
|  Sealed_IntMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|    Open_IntMethod | 0.5804 ns |  1.3546 ns | 0.0743 ns | 0.0429 ns | 0.5174 ns | 0.6623 ns |  1,722,979,239.3 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
|   Sealed_ToString | 8.8360 ns |  4.4997 ns | 0.2466 ns | 0.1424 ns | 8.5516 ns | 8.9913 ns |    113,173,697.6 |      - |         - |
|     Open_ToString | 9.4987 ns |  5.0654 ns | 0.2777 ns | 0.1603 ns | 9.1987 ns | 9.7466 ns |    105,277,812.0 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_VoidMethod | 0.0635 ns |  2.0068 ns | 0.1100 ns | 0.0635 ns | 0.0000 ns | 0.1905 ns | 15,746,108,338.9 |      - |         - |
|   Open_VoidMethod | 0.5880 ns |  1.3016 ns | 0.0713 ns | 0.0412 ns | 0.5139 ns | 0.6563 ns |  1,700,543,783.3 |      - |         - |
