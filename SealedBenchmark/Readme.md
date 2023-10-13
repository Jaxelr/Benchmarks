# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 4.7129 ns |  1.1321 ns | 0.0621 ns | 0.0358 ns | 4.6750 ns | 4.7845 ns |     212,183,278.3 | 0.0038 |      24 B |
| Open_AddToArray   | 7.3137 ns | 33.0813 ns | 1.8133 ns | 1.0469 ns | 6.0071 ns | 9.3839 ns |     136,729,181.0 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.1690 ns |  2.8923 ns | 0.1585 ns | 0.0915 ns | 0.0543 ns | 0.3500 ns |   5,915,507,041.5 |      - |         - |
| Open_Casting      | 1.9395 ns |  0.3150 ns | 0.0173 ns | 0.0100 ns | 1.9199 ns | 1.9525 ns |     515,589,112.1 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0781 ns |  1.1174 ns | 0.0612 ns | 0.0354 ns | 0.0338 ns | 0.1480 ns |  12,807,381,370.0 |      - |         - |
| Open_IntMethod    | 0.5352 ns |  0.8356 ns | 0.0458 ns | 0.0264 ns | 0.4840 ns | 0.5724 ns |   1,868,540,021.2 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_ToString   | 5.4799 ns |  1.9918 ns | 0.1092 ns | 0.0630 ns | 5.3619 ns | 5.5774 ns |     182,485,998.5 |      - |         - |
| Open_ToString     | 6.0958 ns |  3.2076 ns | 0.1758 ns | 0.1015 ns | 5.9518 ns | 6.2917 ns |     164,047,181.7 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0077 ns |  0.1709 ns | 0.0094 ns | 0.0054 ns | 0.0000 ns | 0.0181 ns | 130,234,716,261.0 |      - |         - |
| Open_VoidMethod   | 0.6651 ns |  2.1844 ns | 0.1197 ns | 0.0691 ns | 0.5388 ns | 0.7770 ns |   1,503,503,029.8 |      - |         - |
