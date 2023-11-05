# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean         | Error       | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0     | Gen1   | Allocated |
|-------------------- |--------------------- |-------------:|------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     996.8 ns |  2,076.1 ns |   113.80 ns |    65.70 ns |     894.0 ns |   1,119.1 ns | 1,003,238.2 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   3,271.1 ns |    366.1 ns |    20.07 ns |    11.58 ns |   3,248.8 ns |   3,287.6 ns |   305,705.2 |   1.2398 | 0.0153 |   7.61 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3,446.0 ns |  4,439.1 ns |   243.32 ns |   140.48 ns |   3,293.6 ns |   3,726.6 ns |   290,189.6 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   4,928.6 ns |  1,045.4 ns |    57.30 ns |    33.08 ns |   4,882.1 ns |   4,992.6 ns |   202,897.7 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |   8,059.5 ns |  3,895.0 ns |   213.50 ns |   123.26 ns |   7,873.2 ns |   8,292.4 ns |   124,077.8 |   7.8125 | 0.0763 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  17,216.4 ns |  8,523.3 ns |   467.19 ns |   269.73 ns |  16,688.2 ns |  17,575.4 ns |    58,084.1 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  25,610.8 ns | 16,857.0 ns |   923.99 ns |   533.47 ns |  25,027.4 ns |  26,676.1 ns |    39,046.0 |   5.9509 | 0.2441 |  36.46 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  43,797.2 ns |  6,399.6 ns |   350.78 ns |   202.53 ns |  43,581.3 ns |  44,201.9 ns |    22,832.5 |  10.4980 | 0.6714 |  64.36 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  44,536.9 ns | 28,219.3 ns | 1,546.79 ns |   893.04 ns |  43,533.2 ns |  46,318.2 ns |    22,453.3 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  60,484.4 ns | 13,232.5 ns |   725.32 ns |   418.76 ns |  59,911.5 ns |  61,299.9 ns |    16,533.2 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 110,025.0 ns | 32,662.5 ns | 1,790.34 ns | 1,033.65 ns | 108,202.7 ns | 111,781.6 ns |     9,088.8 | 195.4346 | 2.3193 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 142,472.6 ns | 83,231.5 ns | 4,562.20 ns | 2,633.99 ns | 137,370.1 ns | 146,158.3 ns |     7,018.9 |  10.9863 | 0.9766 |  67.82 KB |
