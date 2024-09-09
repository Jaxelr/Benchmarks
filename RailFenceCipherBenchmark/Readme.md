# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean       | Error     | StdDev    | StdErr    | Min        | Max        | Op/s      | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-----------:|----------:|----------:|----------:|-----------:|-----------:|----------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   2.198 μs |  1.900 μs | 0.1041 μs | 0.0601 μs |   2.078 μs |   2.268 μs | 454,962.2 |   0.4902 | 0.0019 |    3.01 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3.616 μs | 19.501 μs | 1.0689 μs | 0.6171 μs |   2.681 μs |   4.782 μs | 276,519.3 |   1.2436 | 0.0038 |    7.63 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   3.861 μs |  1.429 μs | 0.0783 μs | 0.0452 μs |   3.796 μs |   3.948 μs | 258,996.6 |   1.4420 | 0.0153 |    8.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4.766 μs | 23.248 μs | 1.2743 μs | 0.7357 μs |   3.705 μs |   6.179 μs | 209,825.6 |   1.0910 | 0.0114 |     6.7 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |   7.080 μs | 17.796 μs | 0.9755 μs | 0.5632 μs |   6.315 μs |   8.178 μs | 141,247.2 |   6.0120 | 0.0610 |   36.88 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  12.755 μs | 17.627 μs | 0.9662 μs | 0.5578 μs |  11.641 μs |  13.368 μs |  78,402.9 |  14.6637 | 0.2594 |   89.92 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  19.523 μs | 25.462 μs | 1.3957 μs | 0.8058 μs |  18.108 μs |  20.898 μs |  51,221.7 |   4.0283 | 0.1526 |   24.74 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  31.781 μs | 45.073 μs | 2.4706 μs | 1.4264 μs |  30.322 μs |  34.634 μs |  31,465.0 |   6.6528 | 0.4883 |   40.92 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  35.130 μs | 17.233 μs | 0.9446 μs | 0.5454 μs |  34.040 μs |  35.713 μs |  28,465.9 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  37.937 μs | 24.392 μs | 1.3370 μs | 0.7719 μs |  36.727 μs |  39.372 μs |  26,359.7 |   6.2866 | 0.3052 |   38.64 KB |
| RailFenceLinqDecode | ****(...)**** [1000] |  78.140 μs |  6.841 μs | 0.3750 μs | 0.2165 μs |  77.714 μs |  78.421 μs |  12,797.5 |  10.9863 | 0.8545 |   67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 158.189 μs | 56.550 μs | 3.0997 μs | 1.7896 μs | 154.826 μs | 160.931 μs |   6,321.5 | 191.6504 | 2.1973 | 1174.66 KB |
