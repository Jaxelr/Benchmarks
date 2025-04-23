# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 3.8671 ns |  0.1460 ns | 0.0080 ns | 0.0046 ns | 3.8603 ns | 3.8760 ns |    258,590,153.1 | 0.0038 |      24 B |
| Open_AddToArray   | 4.7389 ns |  0.7005 ns | 0.0384 ns | 0.0222 ns | 4.7001 ns | 4.7769 ns |    211,020,626.3 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                  |        |           |
| Open_Casting      | 0.0136 ns |  0.1222 ns | 0.0067 ns | 0.0039 ns | 0.0087 ns | 0.0212 ns | 73,768,297,012.8 |      - |         - |
| Sealed_Casting    | 0.4961 ns |  0.1238 ns | 0.0068 ns | 0.0039 ns | 0.4886 ns | 0.5018 ns |  2,015,591,913.1 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Open_IntMethod    | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Sealed_IntMethod  | 0.1246 ns |  3.8846 ns | 0.2129 ns | 0.1229 ns | 0.0000 ns | 0.3705 ns |  8,025,452,112.0 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_ToString   | 4.4584 ns | 25.3220 ns | 1.3880 ns | 0.8014 ns | 3.5078 ns | 6.0512 ns |    224,294,044.2 |      - |         - |
| Open_ToString     | 5.0921 ns | 17.1138 ns | 0.9381 ns | 0.5416 ns | 4.0493 ns | 5.8671 ns |    196,381,739.1 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Open_VoidMethod   | 0.0268 ns |  0.8454 ns | 0.0463 ns | 0.0268 ns | 0.0000 ns | 0.0803 ns | 37,376,663,000.0 |      - |         - |
| Sealed_VoidMethod | 0.0291 ns |  0.9205 ns | 0.0505 ns | 0.0291 ns | 0.0000 ns | 0.0874 ns | 34,329,272,283.2 |      - |         - |
