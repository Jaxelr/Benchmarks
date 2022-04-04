# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.


``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1586 (21H2)
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.201
  [Host]   : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  ShortRun : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |      Error |     StdDev |    Gen 0 | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|-----------:|---------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   2.027 μs |   5.519 μs |  0.3025 μs |   2.0981 |      3 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   8.852 μs |  30.532 μs |  1.6735 μs |   5.1193 |      8 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  10.464 μs |  35.950 μs |  1.9705 μs |   4.9591 |      8 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  14.303 μs |  64.914 μs |  3.5582 μs |   5.7678 |      9 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  24.832 μs |  52.780 μs |  2.8930 μs |  31.2500 |     48 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  47.555 μs | 182.342 μs |  9.9948 μs |  73.4863 |    113 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  58.205 μs | 150.284 μs |  8.2376 μs |  23.8037 |     36 KB |
| RailFenceLoopDecode |  ****(...)**** [500] | 112.833 μs |  19.603 μs |  1.0745 μs | 220.4590 |    338 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 116.663 μs | 319.864 μs | 17.5328 μs |  41.9922 |     64 KB |
| RailFenceLinqDecode |  ****(...)**** [500] | 142.270 μs | 202.089 μs | 11.0772 μs |  25.1465 |     39 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 279.989 μs | 216.334 μs | 11.8580 μs | 781.2500 |  1,197 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 341.642 μs | 967.818 μs | 53.0494 μs |  43.9453 |     68 KB |
