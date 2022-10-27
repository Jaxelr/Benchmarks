# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                            Method |      Mean |      Error |    StdDev |    StdErr |       Min |       Max |             Op/s |   Gen0 | Allocated |
|---------------------------------- |----------:|-----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
|                   Open_AddToArray | 5.6506 ns |  6.9181 ns | 0.3792 ns | 0.2189 ns | 5.3207 ns | 6.0649 ns |    176,973,086.6 | 0.0038 |      24 B |
|                 Sealed_AddToArray | 6.0052 ns | 11.2095 ns | 0.6144 ns | 0.3547 ns | 5.5231 ns | 6.6970 ns |    166,522,615.9 | 0.0038 |      24 B |
|                                   |           |            |           |           |           |           |                  |        |           |
|                    Sealed_Casting | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                      Open_Casting | 2.4236 ns |  4.6311 ns | 0.2538 ns | 0.1466 ns | 2.2646 ns | 2.7163 ns |    412,610,591.6 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
| SealedDeclaredInMethod_VoidMethod | 0.4199 ns |  2.4285 ns | 0.1331 ns | 0.0769 ns | 0.3259 ns | 0.5722 ns |  2,381,726,091.5 |      - |         - |
|   OpenDeclaredInMethod_VoidMethod | 0.4526 ns |  3.4310 ns | 0.1881 ns | 0.1086 ns | 0.2646 ns | 0.6408 ns |  2,209,593,706.7 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                  Sealed_IntMethod | 0.1388 ns |  2.8748 ns | 0.1576 ns | 0.0910 ns | 0.0000 ns | 0.3101 ns |  7,206,333,863.7 |      - |         - |
|                    Open_IntMethod | 0.9110 ns |  0.2104 ns | 0.0115 ns | 0.0067 ns | 0.8990 ns | 0.9219 ns |  1,097,635,594.7 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|               Sealed_StaticMethod | 0.0639 ns |  1.1503 ns | 0.0630 ns | 0.0364 ns | 0.0000 ns | 0.1261 ns | 15,653,551,868.4 |      - |         - |
|                 Open_StaticMethod | 0.5986 ns |  3.3060 ns | 0.1812 ns | 0.1046 ns | 0.4272 ns | 0.7882 ns |  1,670,551,800.5 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                   Sealed_ToString | 5.5834 ns |  8.6821 ns | 0.4759 ns | 0.2748 ns | 5.0411 ns | 5.9312 ns |    179,102,035.4 |      - |         - |
|                     Open_ToString | 5.6053 ns | 19.6332 ns | 1.0762 ns | 0.6213 ns | 4.3627 ns | 6.2298 ns |    178,401,657.8 |      - |         - |
|                                   |           |            |           |           |           |           |                  |        |           |
|                 Sealed_VoidMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                   Open_VoidMethod | 0.5874 ns |  2.3770 ns | 0.1303 ns | 0.0752 ns | 0.4998 ns | 0.7371 ns |  1,702,430,247.0 |      - |         - |
