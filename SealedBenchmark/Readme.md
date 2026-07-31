# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 2.7577 ns | 0.3983 ns | 0.0218 ns | 0.0126 ns | 2.7402 ns | 2.7822 ns |     362,622,326.3 | 0.0057 |      24 B |
| Open_AddToArray   | 4.0682 ns | 1.5395 ns | 0.0844 ns | 0.0487 ns | 3.9937 ns | 4.1598 ns |     245,810,920.5 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0076 ns | 0.0420 ns | 0.0023 ns | 0.0013 ns | 0.0055 ns | 0.0101 ns | 131,090,135,842.4 |      - |         - |
| Sealed_IntMethod  | 0.0078 ns | 0.0709 ns | 0.0039 ns | 0.0022 ns | 0.0042 ns | 0.0119 ns | 128,705,897,921.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 0.1688 ns | 0.0898 ns | 0.0049 ns | 0.0028 ns | 0.1656 ns | 0.1745 ns |   5,923,443,558.2 |      - |         - |
| Open_ToString     | 0.3823 ns | 0.0365 ns | 0.0020 ns | 0.0012 ns | 0.3800 ns | 0.3836 ns |   2,615,433,527.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0649 ns | 0.2111 ns | 0.0116 ns | 0.0067 ns | 0.0520 ns | 0.0742 ns |  15,401,743,999.9 |      - |         - |
| Open_VoidMethod   | 0.1561 ns | 2.4322 ns | 0.1333 ns | 0.0770 ns | 0.0784 ns | 0.3100 ns |   6,406,670,968.0 |      - |         - |
