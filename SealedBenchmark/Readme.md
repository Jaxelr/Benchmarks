# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1702)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method |      Mean |      Error |    StdDev |    StdErr |       Min |        Max |            Op/s |   Gen0 | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|-----------:|----------------:|-------:|----------:|
| Sealed_AddToArray | 7.4977 ns | 14.5773 ns | 0.7990 ns | 0.4613 ns | 6.7948 ns |  8.3668 ns |   133,373,973.1 | 0.0038 |      24 B |
|   Open_AddToArray | 7.7467 ns |  9.1819 ns | 0.5033 ns | 0.2906 ns | 7.2359 ns |  8.2422 ns |   129,087,216.8 | 0.0038 |      24 B |
|                   |           |            |           |           |           |            |                 |        |           |
|    Sealed_Casting | 0.2825 ns |  1.0016 ns | 0.0549 ns | 0.0317 ns | 0.2263 ns |  0.3360 ns | 3,539,801,987.2 |      - |         - |
|      Open_Casting | 4.7482 ns | 15.9039 ns | 0.8717 ns | 0.5033 ns | 4.2285 ns |  5.7546 ns |   210,606,438.2 |      - |         - |
|                   |           |            |           |           |           |            |                 |        |           |
|  Sealed_IntMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |        Infinity |      - |         - |
|    Open_IntMethod | 1.0171 ns |  5.1901 ns | 0.2845 ns | 0.1642 ns | 0.6908 ns |  1.2131 ns |   983,192,843.8 |      - |         - |
|                   |           |            |           |           |           |            |                 |        |           |
|     Open_ToString | 6.7119 ns |  7.9840 ns | 0.4376 ns | 0.2527 ns | 6.2158 ns |  7.0433 ns |   148,989,693.6 |      - |         - |
|   Sealed_ToString | 9.7644 ns | 12.8037 ns | 0.7018 ns | 0.4052 ns | 8.9746 ns | 10.3163 ns |   102,412,668.2 |      - |         - |
|                   |           |            |           |           |           |            |                 |        |           |
| Sealed_VoidMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |        Infinity |      - |         - |
|   Open_VoidMethod | 1.3908 ns |  4.3347 ns | 0.2376 ns | 0.1372 ns | 1.1380 ns |  1.6096 ns |   718,986,759.0 |      - |         - |
