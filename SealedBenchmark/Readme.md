# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Open_AddToArray   | 5.7779 ns |  4.8471 ns | 0.2657 ns | 0.1534 ns | 5.4722 ns | 5.9530 ns |     173,072,029.4 | 0.0038 |      24 B |
| Sealed_AddToArray | 6.1843 ns | 11.7944 ns | 0.6465 ns | 0.3733 ns | 5.5016 ns | 6.7872 ns |     161,698,530.7 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.3128 ns |  1.8648 ns | 0.1022 ns | 0.0590 ns | 0.1988 ns | 0.3963 ns |   3,197,012,577.5 |      - |         - |
| Open_Casting      | 1.3005 ns |  0.2585 ns | 0.0142 ns | 0.0082 ns | 1.2911 ns | 1.3168 ns |     768,962,435.1 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0078 ns |  0.2338 ns | 0.0128 ns | 0.0074 ns | 0.0000 ns | 0.0226 ns | 127,694,659,161.2 |      - |         - |
| Sealed_IntMethod  | 0.0165 ns |  0.4022 ns | 0.0220 ns | 0.0127 ns | 0.0000 ns | 0.0415 ns |  60,621,823,684.0 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Open_ToString     | 5.8154 ns |  6.3827 ns | 0.3499 ns | 0.2020 ns | 5.5522 ns | 6.2124 ns |     171,958,460.1 |      - |         - |
| Sealed_ToString   | 6.1803 ns | 22.2082 ns | 1.2173 ns | 0.7028 ns | 5.4384 ns | 7.5852 ns |     161,804,200.8 |      - |         - |
|                   |           |            |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0544 ns |  0.3450 ns | 0.0189 ns | 0.0109 ns | 0.0386 ns | 0.0754 ns |  18,388,677,067.0 |      - |         - |
| Open_VoidMethod   | 0.2728 ns |  0.2085 ns | 0.0114 ns | 0.0066 ns | 0.2627 ns | 0.2852 ns |   3,666,216,119.8 |      - |         - |
