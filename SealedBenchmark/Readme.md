# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 2.4746 ns | 0.4408 ns | 0.0242 ns | 0.0140 ns | 2.4469 ns | 2.4914 ns |     404,108,216.0 | 0.0057 |      24 B |
| Open_AddToArray   | 2.8243 ns | 1.7609 ns | 0.0965 ns | 0.0557 ns | 2.7189 ns | 2.9084 ns |     354,070,031.2 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0012 ns | 0.0380 ns | 0.0021 ns | 0.0012 ns | 0.0000 ns | 0.0036 ns | 831,026,642,588.1 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0120 ns | 0.3779 ns | 0.0207 ns | 0.0120 ns | 0.0000 ns | 0.0359 ns |  83,625,621,034.5 |      - |         - |
| Open_IntMethod    | 0.0365 ns | 0.0345 ns | 0.0019 ns | 0.0011 ns | 0.0344 ns | 0.0380 ns |  27,391,186,726.6 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_ToString     | 1.7823 ns | 6.5664 ns | 0.3599 ns | 0.2078 ns | 1.5703 ns | 2.1978 ns |     561,083,185.1 |      - |         - |
| Sealed_ToString   | 2.1609 ns | 0.0766 ns | 0.0042 ns | 0.0024 ns | 2.1562 ns | 2.1643 ns |     462,766,613.4 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_VoidMethod   | 0.0680 ns | 1.1899 ns | 0.0652 ns | 0.0377 ns | 0.0000 ns | 0.1300 ns |  14,709,383,171.6 |      - |         - |
| Sealed_VoidMethod | 0.2534 ns | 0.0341 ns | 0.0019 ns | 0.0011 ns | 0.2513 ns | 0.2549 ns |   3,946,633,236.8 |      - |         - |
