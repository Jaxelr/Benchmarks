# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4202)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean       | Error       | StdDev     | StdErr    | Min        | Max        | Op/s      | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.522 μs |   0.4139 μs |  0.0227 μs | 0.0131 μs |   1.499 μs |   1.544 μs | 656,999.1 |   0.4845 | 0.0019 |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3.950 μs |   6.7795 μs |  0.3716 μs | 0.2145 μs |   3.706 μs |   4.378 μs | 253,162.4 |   1.2436 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4.973 μs |   0.9769 μs |  0.0535 μs | 0.0309 μs |   4.916 μs |   5.023 μs | 201,101.5 |   1.0452 | 0.0076 |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   6.938 μs |   3.4984 μs |  0.1918 μs | 0.1107 μs |   6.728 μs |   7.103 μs | 144,127.7 |   1.2665 | 0.0153 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  13.965 μs |   0.4362 μs |  0.0239 μs | 0.0138 μs |  13.939 μs |  13.984 μs |  71,606.2 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  28.052 μs |  10.6814 μs |  0.5855 μs | 0.3380 μs |  27.376 μs |  28.402 μs |  35,648.2 |   3.9978 | 0.1526 |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  28.979 μs |  30.2177 μs |  1.6563 μs | 0.9563 μs |  27.087 μs |  30.166 μs |  34,507.8 |  14.6484 | 0.2441 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  51.701 μs |   2.9169 μs |  0.1599 μs | 0.0923 μs |  51.516 μs |  51.802 μs |  19,342.1 |   6.5918 | 0.4883 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  56.636 μs |  11.3181 μs |  0.6204 μs | 0.3582 μs |  55.950 μs |  57.157 μs |  17,656.6 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  89.714 μs |  38.5250 μs |  2.1117 μs | 1.2192 μs |  88.030 μs |  92.083 μs |  11,146.6 |  53.3447 | 0.3662 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 116.662 μs |  48.7036 μs |  2.6696 μs | 1.5413 μs | 113.776 μs | 119.044 μs |   8,571.8 |   9.6436 | 0.8545 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 263.682 μs | 232.9536 μs | 12.7690 μs | 7.3722 μs | 251.786 μs | 277.174 μs |   3,792.5 | 191.4063 | 1.9531 | 1174.66 KB |
