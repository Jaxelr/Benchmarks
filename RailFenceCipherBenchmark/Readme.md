# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |         Mean |        Error |      StdDev |      StdErr |          Min |          Max |        Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     884.8 ns |     453.1 ns |    24.84 ns |    14.34 ns |     867.7 ns |     913.3 ns | 1,130,142.6 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3,185.6 ns |   3,421.5 ns |   187.55 ns |   108.28 ns |   3,059.0 ns |   3,401.1 ns |   313,907.7 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   3,742.8 ns |   3,804.7 ns |   208.55 ns |   120.40 ns |   3,587.4 ns |   3,979.8 ns |   267,176.6 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   5,241.0 ns |     798.8 ns |    43.79 ns |    25.28 ns |   5,209.5 ns |   5,291.0 ns |   190,801.7 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  10,627.9 ns |  16,240.6 ns |   890.20 ns |   513.96 ns |   9,853.4 ns |  11,600.4 ns |    94,092.4 |   7.8125 | 0.1068 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  23,932.0 ns |  33,280.1 ns | 1,824.19 ns | 1,053.20 ns |  21,825.8 ns |  25,012.1 ns |    41,785.1 |  18.3716 | 0.4578 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  25,764.4 ns |   3,952.1 ns |   216.63 ns |   125.07 ns |  25,562.9 ns |  25,993.5 ns |    38,813.2 |   5.9509 | 0.2441 |  36.46 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  44,522.2 ns |   9,472.7 ns |   519.23 ns |   299.78 ns |  43,939.4 ns |  44,935.5 ns |    22,460.7 |  55.1758 | 0.6104 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  57,176.3 ns | 172,869.2 ns | 9,475.54 ns | 5,470.71 ns |  50,715.3 ns |  68,053.8 ns |    17,489.8 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  62,263.7 ns |  45,253.4 ns | 2,480.49 ns | 1,432.11 ns |  60,457.9 ns |  65,092.0 ns |    16,060.7 |   6.2256 | 0.3662 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 115,368.4 ns | 128,220.9 ns | 7,028.22 ns | 4,057.74 ns | 110,243.3 ns | 123,380.3 ns |     8,667.9 | 195.4346 | 3.7842 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 151,462.0 ns |  56,968.4 ns | 3,122.63 ns | 1,802.85 ns | 149,106.5 ns | 155,004.0 ns |     6,602.3 |  10.9863 | 0.9766 |  67.82 KB |
