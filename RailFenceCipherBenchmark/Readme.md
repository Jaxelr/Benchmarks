# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |         Mean |        Error |      StdDev |      StdErr |          Min |          Max |        Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     992.7 ns |     704.6 ns |    38.62 ns |    22.30 ns |     963.2 ns |   1,036.4 ns | 1,007,344.1 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3,036.3 ns |   1,480.2 ns |    81.13 ns |    46.84 ns |   2,943.9 ns |   3,095.6 ns |   329,345.4 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4,076.9 ns |   3,648.6 ns |   199.99 ns |   115.46 ns |   3,899.0 ns |   4,293.3 ns |   245,284.5 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   6,203.0 ns |   6,015.8 ns |   329.75 ns |   190.38 ns |   5,838.4 ns |   6,480.3 ns |   161,212.2 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  11,183.2 ns |   3,664.4 ns |   200.86 ns |   115.97 ns |  10,953.3 ns |  11,324.6 ns |    89,419.5 |   7.8125 | 0.1068 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  27,264.9 ns |  61,537.8 ns | 3,373.10 ns | 1,947.46 ns |  24,980.3 ns |  31,139.1 ns |    36,677.2 |  18.3716 | 0.4578 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  31,242.2 ns |  14,544.6 ns |   797.24 ns |   460.29 ns |  30,324.9 ns |  31,768.1 ns |    32,008.0 |   5.9204 | 0.2441 |  36.46 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  64,712.9 ns |  23,386.9 ns | 1,281.91 ns |   740.11 ns |  63,413.3 ns |  65,976.3 ns |    15,452.9 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  80,594.7 ns | 107,167.6 ns | 5,874.22 ns | 3,391.48 ns |  73,833.7 ns |  84,447.3 ns |    12,407.8 |   6.2256 | 0.3662 |  38.64 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  93,939.5 ns | 147,275.6 ns | 8,072.67 ns | 4,660.76 ns |  85,501.1 ns | 101,588.5 ns |    10,645.1 |  55.1758 | 0.4883 | 338.03 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 121,189.5 ns |  15,118.8 ns |   828.71 ns |   478.46 ns | 120,328.7 ns | 121,981.9 ns |     8,251.5 | 195.3125 | 3.6621 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 145,326.5 ns |  16,980.2 ns |   930.74 ns |   537.36 ns | 144,316.5 ns | 146,149.6 ns |     6,881.1 |  10.9863 | 0.9766 |  67.82 KB |
