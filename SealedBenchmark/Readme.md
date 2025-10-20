# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 2.2882 ns | 0.8630 ns | 0.0473 ns | 0.0273 ns | 2.2486 ns | 2.3406 ns |    437,018,576.8 | 0.0057 |      24 B |
| Open_AddToArray   | 3.5265 ns | 0.7960 ns | 0.0436 ns | 0.0252 ns | 3.4839 ns | 3.5711 ns |    283,568,944.5 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_Casting      | 0.0215 ns | 0.3544 ns | 0.0194 ns | 0.0112 ns | 0.0000 ns | 0.0378 ns | 46,461,144,297.8 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Open_IntMethod    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Sealed_IntMethod  | 0.0378 ns | 0.1817 ns | 0.0100 ns | 0.0057 ns | 0.0303 ns | 0.0491 ns | 26,433,647,834.3 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_ToString   | 1.8273 ns | 0.7667 ns | 0.0420 ns | 0.0243 ns | 1.7937 ns | 1.8744 ns |    547,245,370.8 |      - |         - |
| Open_ToString     | 1.9146 ns | 0.7314 ns | 0.0401 ns | 0.0231 ns | 1.8836 ns | 1.9599 ns |    522,303,383.2 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_VoidMethod | 0.0241 ns | 0.3439 ns | 0.0189 ns | 0.0109 ns | 0.0081 ns | 0.0449 ns | 41,505,502,824.4 |      - |         - |
| Open_VoidMethod   | 0.1745 ns | 0.6703 ns | 0.0367 ns | 0.0212 ns | 0.1520 ns | 0.2169 ns |  5,732,199,344.9 |      - |         - |
