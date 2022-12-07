# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                            Method |      Mean |      Error |    StdDev |    StdErr |       Min |       Max |             Op/s |   Gen0 | Allocated |
|---------------------------------- |----------:|-----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
|                 Sealed_AddToArray | 5.0789 ns |  2.4070 ns | 0.1319 ns | 0.0762 ns | 4.9816 ns | 5.2291 ns |    196,892,523.2 | 0.0038 |      24 B |
|                   Open_AddToArray | 6.7008 ns | 15.4030 ns | 0.8443 ns | 0.4875 ns | 6.0604 ns | 7.6576 ns |    149,235,948.4 | 0.0038 |      24 B |
|                                   |           |            |           |           |           |           |                  |        |           |
|                    Sealed_Casting | 0.2085 ns |  0.7510 ns | 0.0412 ns | 0.0238 ns | 0.1646 ns | 0.2462 ns |  4,796,259,554.6 |      - |         - |
|                      Open_Casting | 2.2036 ns |  1.8524 ns | 0.1015 ns | 0.0586 ns | 2.0929 ns | 2.2924 ns |    453,793,051.6 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|   OpenDeclaredInMethod_VoidMethod | 0.0180 ns |  0.2910 ns | 0.0160 ns | 0.0092 ns | 0.0000 ns | 0.0304 ns | 55,547,564,286.5 |      - |         - |
| SealedDeclaredInMethod_VoidMethod | 0.0775 ns |  1.9743 ns | 0.1082 ns | 0.0625 ns | 0.0128 ns | 0.2024 ns | 12,909,874,749.7 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                  Sealed_IntMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                    Open_IntMethod | 0.5599 ns |  1.3736 ns | 0.0753 ns | 0.0435 ns | 0.4940 ns | 0.6420 ns |  1,785,897,108.5 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|               Sealed_StaticMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                 Open_StaticMethod | 0.0135 ns |  0.4268 ns | 0.0234 ns | 0.0135 ns | 0.0000 ns | 0.0405 ns | 74,041,628,480.0 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                     Open_ToString | 6.5655 ns |  7.9603 ns | 0.4363 ns | 0.2519 ns | 6.1224 ns | 6.9948 ns |    152,311,467.2 |      - |         - |
|                   Sealed_ToString | 7.3374 ns | 31.0538 ns | 1.7022 ns | 0.9827 ns | 6.1603 ns | 9.2891 ns |    136,288,264.7 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                 Sealed_VoidMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                   Open_VoidMethod | 0.5090 ns |  1.6755 ns | 0.0918 ns | 0.0530 ns | 0.4136 ns | 0.5968 ns |  1,964,575,871.6 |      - |         - |
