# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.6584)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 2.5536 ns | 0.8176 ns | 0.0448 ns | 0.0259 ns | 2.5239 ns | 2.6052 ns |     391,596,515.1 | 0.0057 |      24 B |
| Open_AddToArray   | 3.7100 ns | 0.1985 ns | 0.0109 ns | 0.0063 ns | 3.6979 ns | 3.7190 ns |     269,544,920.9 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0113 ns | 0.2459 ns | 0.0135 ns | 0.0078 ns | 0.0024 ns | 0.0268 ns |  88,719,441,225.1 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0048 ns | 0.1513 ns | 0.0083 ns | 0.0048 ns | 0.0000 ns | 0.0144 ns | 208,872,096,485.5 |      - |         - |
| Open_IntMethod    | 0.0068 ns | 0.1070 ns | 0.0059 ns | 0.0034 ns | 0.0000 ns | 0.0106 ns | 148,050,587,932.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 2.0748 ns | 1.5638 ns | 0.0857 ns | 0.0495 ns | 1.9763 ns | 2.1330 ns |     481,980,441.0 |      - |         - |
| Open_ToString     | 2.2042 ns | 0.3061 ns | 0.0168 ns | 0.0097 ns | 2.1857 ns | 2.2184 ns |     453,686,009.4 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0053 ns | 0.1673 ns | 0.0092 ns | 0.0053 ns | 0.0000 ns | 0.0159 ns | 188,875,007,153.4 |      - |         - |
| Open_VoidMethod   | 0.0150 ns | 0.0139 ns | 0.0008 ns | 0.0004 ns | 0.0142 ns | 0.0157 ns |  66,669,401,528.3 |      - |         - |
