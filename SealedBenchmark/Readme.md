# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9818)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.403
  [Host]   : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 2.9685 ns | 0.4427 ns | 0.0243 ns | 0.0140 ns | 2.9496 ns | 2.9959 ns |    336,870,565.4 | 0.0057 |      24 B |
| Open_AddToArray   | 4.1670 ns | 3.7215 ns | 0.2040 ns | 0.1178 ns | 4.0285 ns | 4.4012 ns |    239,981,333.3 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_Casting      | 0.0221 ns | 0.5002 ns | 0.0274 ns | 0.0158 ns | 0.0000 ns | 0.0528 ns | 45,164,288,806.9 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Open_IntMethod    | 0.0341 ns | 0.2477 ns | 0.0136 ns | 0.0078 ns | 0.0237 ns | 0.0494 ns | 29,358,384,845.9 |      - |         - |
| Sealed_IntMethod  | 0.0565 ns | 0.9816 ns | 0.0538 ns | 0.0311 ns | 0.0000 ns | 0.1071 ns | 17,695,929,682.7 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_ToString   | 0.4837 ns | 0.8464 ns | 0.0464 ns | 0.0268 ns | 0.4343 ns | 0.5263 ns |  2,067,422,040.3 |      - |         - |
| Open_ToString     | 0.8113 ns | 0.5721 ns | 0.0314 ns | 0.0181 ns | 0.7761 ns | 0.8361 ns |  1,232,539,596.2 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_VoidMethod | 0.0390 ns | 0.6170 ns | 0.0338 ns | 0.0195 ns | 0.0000 ns | 0.0601 ns | 25,636,371,589.2 |      - |         - |
| Open_VoidMethod   | 0.2651 ns | 1.2444 ns | 0.0682 ns | 0.0394 ns | 0.1879 ns | 0.3173 ns |  3,772,352,607.5 |      - |         - |
