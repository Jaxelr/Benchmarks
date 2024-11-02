# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 4.9684 ns | 4.8008 ns | 0.2631 ns | 0.1519 ns | 4.6870 ns | 5.2084 ns |     201,273,415.6 | 0.0038 |      24 B |
| Open_AddToArray   | 5.9269 ns | 0.3456 ns | 0.0189 ns | 0.0109 ns | 5.9119 ns | 5.9482 ns |     168,720,934.1 | 0.0038 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0238 ns | 0.0299 ns | 0.0016 ns | 0.0009 ns | 0.0220 ns | 0.0251 ns |  41,997,286,495.1 |      - |         - |
| Open_Casting      | 1.0543 ns | 0.1913 ns | 0.0105 ns | 0.0061 ns | 1.0468 ns | 1.0663 ns |     948,525,348.6 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0014 ns | 0.0450 ns | 0.0025 ns | 0.0014 ns | 0.0000 ns | 0.0043 ns | 702,710,617,801.0 |      - |         - |
| Open_IntMethod    | 0.2400 ns | 0.0843 ns | 0.0046 ns | 0.0027 ns | 0.2367 ns | 0.2453 ns |   4,165,979,677.8 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_ToString     | 4.7697 ns | 0.1285 ns | 0.0070 ns | 0.0041 ns | 4.7631 ns | 4.7771 ns |     209,656,867.3 |      - |         - |
| Sealed_ToString   | 4.8444 ns | 0.2041 ns | 0.0112 ns | 0.0065 ns | 4.8375 ns | 4.8573 ns |     206,422,481.9 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_VoidMethod   | 0.2423 ns | 0.0787 ns | 0.0043 ns | 0.0025 ns | 0.2386 ns | 0.2470 ns |   4,127,507,175.5 |      - |         - |
