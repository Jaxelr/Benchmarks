# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4202)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s             | Gen0   | Allocated |
|------------------ |-----------:|-----------:|----------:|----------:|-----------:|-----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 16.7497 ns |  4.7936 ns | 0.2628 ns | 0.1517 ns | 16.4843 ns | 17.0098 ns |     59,702,533.8 | 0.0038 |      24 B |
| Open_AddToArray   | 18.7403 ns | 11.1381 ns | 0.6105 ns | 0.3525 ns | 18.0719 ns | 19.2686 ns |     53,360,994.3 | 0.0038 |      24 B |
|                   |            |            |           |           |            |            |                  |        |           |
| Open_Casting      |  0.5221 ns |  0.9790 ns | 0.0537 ns | 0.0310 ns |  0.4631 ns |  0.5680 ns |  1,915,456,942.2 |      - |         - |
| Sealed_Casting    |  1.4905 ns |  0.2715 ns | 0.0149 ns | 0.0086 ns |  1.4754 ns |  1.5051 ns |    670,936,561.0 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
| Open_IntMethod    |  0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |         Infinity |      - |         - |
| Sealed_IntMethod  |  0.0149 ns |  0.4712 ns | 0.0258 ns | 0.0149 ns |  0.0000 ns |  0.0447 ns | 67,062,479,118.6 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
| Sealed_ToString   |  6.5645 ns |  2.9070 ns | 0.1593 ns | 0.0920 ns |  6.4175 ns |  6.7338 ns |    152,334,966.1 |      - |         - |
| Open_ToString     |  6.6158 ns |  6.6932 ns | 0.3669 ns | 0.2118 ns |  6.3810 ns |  7.0385 ns |    151,154,010.9 |      - |         - |
|                   |            |            |           |           |            |            |                  |        |           |
| Sealed_VoidMethod |  0.0564 ns |  0.8973 ns | 0.0492 ns | 0.0284 ns |  0.0000 ns |  0.0905 ns | 17,735,838,046.4 |      - |         - |
| Open_VoidMethod   |  0.1815 ns |  1.6638 ns | 0.0912 ns | 0.0527 ns |  0.0799 ns |  0.2563 ns |  5,508,485,093.1 |      - |         - |
