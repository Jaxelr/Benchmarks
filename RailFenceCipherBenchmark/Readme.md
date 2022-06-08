# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |         Mean |        Error |       StdDev |      StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |    Gen 0 |  Gen 1 | Allocated |
|-------------------- |--------------------- |-------------:|-------------:|-------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     993.1 ns |   2,180.4 ns |    119.51 ns |    69.00 ns |     918.5 ns |     924.2 ns |     929.8 ns |   1,030.4 ns |   1,130.9 ns | 1,006,963.8 |   0.5245 | 0.0019 |      3 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   2,767.1 ns |     900.5 ns |     49.36 ns |    28.50 ns |   2,717.3 ns |   2,742.6 ns |   2,768.0 ns |   2,792.0 ns |   2,816.0 ns |   361,390.7 |   1.2779 | 0.0038 |      8 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   3,968.6 ns |   3,045.8 ns |    166.95 ns |    96.39 ns |   3,791.1 ns |   3,891.6 ns |   3,992.0 ns |   4,057.3 ns |   4,122.6 ns |   251,980.0 |   1.2398 | 0.0153 |      8 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   5,756.4 ns |   4,067.2 ns |    222.94 ns |   128.71 ns |   5,591.5 ns |   5,629.6 ns |   5,667.7 ns |   5,838.9 ns |   6,010.1 ns |   173,718.9 |   1.4420 | 0.0153 |      9 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  10,072.8 ns |  16,750.6 ns |    918.16 ns |   530.10 ns |   9,522.3 ns |   9,542.8 ns |   9,563.3 ns |  10,348.0 ns |  11,132.7 ns |    99,277.4 |   7.8125 | 0.1068 |     48 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  19,799.8 ns |  10,848.8 ns |    594.66 ns |   343.33 ns |  19,436.6 ns |  19,456.7 ns |  19,476.8 ns |  19,981.5 ns |  20,486.1 ns |    50,505.5 |  18.3716 | 0.4272 |    113 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  26,381.5 ns |  23,589.5 ns |  1,293.02 ns |   746.52 ns |  25,082.7 ns |  25,737.9 ns |  26,393.2 ns |  27,030.9 ns |  27,668.6 ns |    37,905.4 |   5.9509 | 0.2441 |     36 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  47,253.6 ns |   9,202.6 ns |    504.43 ns |   291.23 ns |  46,961.3 ns |  46,962.4 ns |  46,963.5 ns |  47,399.8 ns |  47,836.1 ns |    21,162.4 |  10.4980 | 0.7324 |     64 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  53,058.1 ns |  34,996.0 ns |  1,918.25 ns | 1,107.50 ns |  51,355.2 ns |  52,019.0 ns |  52,682.9 ns |  53,909.6 ns |  55,136.2 ns |    18,847.3 |  55.1758 | 0.6104 |    338 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  69,240.7 ns | 107,761.1 ns |  5,906.75 ns | 3,410.26 ns |  63,170.0 ns |  66,376.8 ns |  69,583.5 ns |  72,276.0 ns |  74,968.6 ns |    14,442.4 |   6.2256 | 0.2441 |     39 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 139,984.4 ns |  27,215.5 ns |  1,491.77 ns |   861.28 ns | 139,054.8 ns | 139,124.1 ns | 139,193.3 ns | 140,449.2 ns | 141,705.1 ns |     7,143.7 | 195.3125 | 3.6621 |  1,197 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 141,209.5 ns | 199,765.6 ns | 10,949.82 ns | 6,321.88 ns | 133,725.3 ns | 134,925.7 ns | 136,126.1 ns | 144,951.6 ns | 153,777.0 ns |     7,081.7 |  10.9863 | 0.9766 |     68 KB |
