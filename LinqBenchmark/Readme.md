# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1466 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]   : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  ShortRun : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  Categories=Linq  

```
|      Method |                 list | value |         Mean |         Error |       StdDev |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     616.0 ns |      69.93 ns |      3.83 ns | 0.0305 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     622.6 ns |     450.24 ns |     24.68 ns | 0.0305 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   5,303.0 ns |      82.38 ns |      4.52 ns | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   5,652.8 ns |     634.10 ns |     34.76 ns | 0.0305 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   5,737.9 ns |   1,728.76 ns |     94.76 ns | 0.0305 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   5,747.5 ns |     404.76 ns |     22.19 ns | 0.0305 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   5,864.2 ns |   1,404.53 ns |     76.99 ns | 0.0610 |     256 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  52,137.3 ns |   7,450.19 ns |    408.37 ns |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  52,336.5 ns |   5,179.88 ns |    283.93 ns | 0.0610 |     256 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  55,831.8 ns |   7,815.77 ns |    428.41 ns |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  57,158.3 ns |   3,478.95 ns |    190.69 ns |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  57,347.0 ns |   4,311.41 ns |    236.32 ns |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 523,151.6 ns |  32,681.97 ns |  1,791.41 ns |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 573,606.1 ns |  18,201.72 ns |    997.70 ns |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 612,360.1 ns | 245,716.26 ns | 13,468.54 ns |      - |     139 B |
