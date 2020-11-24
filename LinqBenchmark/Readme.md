# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]   : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  Categories=Linq  

```
|      Method |                 list | value |         Mean |         Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|-------:|------:|------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     623.2 ns |      66.58 ns |      3.65 ns | 0.0305 |     - |     - |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     654.7 ns |     118.58 ns |      6.50 ns | 0.0305 |     - |     - |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   5,554.0 ns |     553.92 ns |     30.36 ns | 0.0305 |     - |     - |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   6,109.9 ns |   1,336.02 ns |     73.23 ns | 0.0305 |     - |     - |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   6,205.0 ns |   1,349.63 ns |     73.98 ns | 0.0305 |     - |     - |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   6,241.2 ns |     674.36 ns |     36.96 ns | 0.0610 |     - |     - |     256 B |
| SingleUsage | Syste(...)rator [36] |   100 |   6,993.4 ns |  14,860.06 ns |    814.53 ns | 0.0305 |     - |     - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  60,108.8 ns |  10,944.35 ns |    599.90 ns |      - |     - |     - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  60,132.8 ns |  16,285.72 ns |    892.68 ns |      - |     - |     - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  60,743.7 ns |   8,426.42 ns |    461.88 ns |      - |     - |     - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  61,502.1 ns |  21,738.54 ns |  1,191.56 ns |      - |     - |     - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  63,781.9 ns |  15,972.18 ns |    875.49 ns |      - |     - |     - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 601,858.8 ns |   4,825.71 ns |    264.51 ns |      - |     - |     - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 627,583.0 ns | 215,457.50 ns | 11,809.95 ns |      - |     - |     - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 644,993.8 ns | 210,454.04 ns | 11,535.70 ns |      - |     - |     - |     256 B |
