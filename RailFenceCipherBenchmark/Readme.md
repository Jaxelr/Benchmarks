# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean       | Error         | StdDev     | StdErr     | Min        | Max        | Op/s      | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-----------:|--------------:|-----------:|-----------:|-----------:|-----------:|----------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.805 μs |     0.7271 μs |  0.0399 μs |  0.0230 μs |   1.760 μs |   1.834 μs | 553,987.6 |   0.4883 |      - |    3.01 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   5.161 μs |     4.2146 μs |  0.2310 μs |  0.1334 μs |   4.929 μs |   5.391 μs | 193,766.8 |   1.2436 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   5.221 μs |     2.7929 μs |  0.1531 μs |  0.0884 μs |   5.056 μs |   5.358 μs | 191,522.9 |   1.0910 | 0.0076 |     6.7 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   8.078 μs |     4.3648 μs |  0.2392 μs |  0.1381 μs |   7.893 μs |   8.348 μs | 123,790.7 |   1.4343 | 0.0153 |    8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  10.588 μs |    23.0277 μs |  1.2622 μs |  0.7287 μs |   9.683 μs |  12.030 μs |  94,445.4 |   6.0120 | 0.0610 |   36.88 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  22.896 μs |    10.7669 μs |  0.5902 μs |  0.3407 μs |  22.224 μs |  23.329 μs |  43,675.7 |  14.6484 | 0.2441 |   89.92 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  38.771 μs |    31.7937 μs |  1.7427 μs |  1.0062 μs |  37.018 μs |  40.503 μs |  25,792.2 |   4.0283 | 0.1221 |   24.74 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  51.721 μs |    21.7569 μs |  1.1926 μs |  0.6885 μs |  50.515 μs |  52.899 μs |  19,334.6 |   6.6528 | 0.4883 |   40.92 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  56.668 μs |    51.4223 μs |  2.8186 μs |  1.6273 μs |  54.970 μs |  59.922 μs |  17,646.6 |   6.2256 | 0.2441 |   38.64 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  62.210 μs |    31.2020 μs |  1.7103 μs |  0.9874 μs |  60.242 μs |  63.340 μs |  16,074.7 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 132.752 μs |   156.5783 μs |  8.5826 μs |  4.9552 μs | 124.798 μs | 141.848 μs |   7,532.8 |  10.9863 | 0.7324 |   67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 282.382 μs | 1,482.3712 μs | 81.2538 μs | 46.9119 μs | 218.738 μs | 373.906 μs |   3,541.3 | 191.6504 | 2.1973 | 1174.66 KB |
