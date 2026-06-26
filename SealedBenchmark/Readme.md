# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 3.0464 ns | 1.3776 ns | 0.0755 ns | 0.0436 ns | 2.9853 ns | 3.1308 ns |     328,259,663.6 | 0.0057 |      24 B |
| Open_AddToArray   | 4.4263 ns | 4.0935 ns | 0.2244 ns | 0.1295 ns | 4.1925 ns | 4.6399 ns |     225,924,494.1 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0464 ns | 1.4654 ns | 0.0803 ns | 0.0464 ns | 0.0000 ns | 0.1391 ns |  21,563,274,657.1 |      - |         - |
| Open_Casting      | 0.0649 ns | 2.0508 ns | 0.1124 ns | 0.0649 ns | 0.0000 ns | 0.1947 ns |  15,408,227,120.8 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0239 ns | 0.1970 ns | 0.0108 ns | 0.0062 ns | 0.0130 ns | 0.0346 ns |  41,854,317,566.4 |      - |         - |
| Open_IntMethod    | 0.2503 ns | 2.3093 ns | 0.1266 ns | 0.0731 ns | 0.1333 ns | 0.3847 ns |   3,994,443,476.9 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 0.4013 ns | 1.5486 ns | 0.0849 ns | 0.0490 ns | 0.3049 ns | 0.4650 ns |   2,491,741,296.6 |      - |         - |
| Open_ToString     | 0.6820 ns | 0.9635 ns | 0.0528 ns | 0.0305 ns | 0.6246 ns | 0.7286 ns |   1,466,372,158.8 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0016 ns | 0.0348 ns | 0.0019 ns | 0.0011 ns | 0.0003 ns | 0.0037 ns | 645,044,950,138.2 |      - |         - |
| Open_VoidMethod   | 0.0458 ns | 0.0215 ns | 0.0012 ns | 0.0007 ns | 0.0451 ns | 0.0472 ns |  21,838,372,589.0 |      - |         - |
