# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 4.0553 ns | 0.5794 ns | 0.0318 ns | 0.0183 ns | 4.0237 ns | 4.0872 ns |     246,588,428.2 | 0.0038 |      24 B |
| Open_AddToArray   | 4.6427 ns | 1.5352 ns | 0.0842 ns | 0.0486 ns | 4.5620 ns | 4.7300 ns |     215,389,686.2 | 0.0038 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_Casting      | 0.0140 ns | 0.1292 ns | 0.0071 ns | 0.0041 ns | 0.0069 ns | 0.0211 ns |  71,679,635,418.5 |      - |         - |
| Sealed_Casting    | 0.4882 ns | 0.2206 ns | 0.0121 ns | 0.0070 ns | 0.4761 ns | 0.5003 ns |   2,048,262,533.6 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Sealed_IntMethod  | 0.0013 ns | 0.0413 ns | 0.0023 ns | 0.0013 ns | 0.0000 ns | 0.0039 ns | 765,354,845,086.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 3.1716 ns | 0.7961 ns | 0.0436 ns | 0.0252 ns | 3.1391 ns | 3.2212 ns |     315,299,935.8 |      - |         - |
| Open_ToString     | 3.1928 ns | 0.7632 ns | 0.0418 ns | 0.0242 ns | 3.1508 ns | 3.2345 ns |     313,207,167.8 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_VoidMethod   | 0.0054 ns | 0.1053 ns | 0.0058 ns | 0.0033 ns | 0.0004 ns | 0.0117 ns | 184,200,546,215.6 |      - |         - |
| Sealed_VoidMethod | 0.0065 ns | 0.2041 ns | 0.0112 ns | 0.0065 ns | 0.0000 ns | 0.0194 ns | 154,844,275,921.7 |      - |         - |
