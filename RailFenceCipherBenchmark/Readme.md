# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev       | StdErr      | Min         | Max          | Op/s        | Gen0     | Gen1   | Allocated |
|-------------------- |--------------------- |------------:|-------------:|-------------:|------------:|------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    637.7 ns |     151.2 ns |      8.29 ns |     4.79 ns |    631.0 ns |     647.0 ns | 1,568,074.5 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  2,584.4 ns |   3,455.6 ns |    189.41 ns |   109.36 ns |  2,372.8 ns |   2,738.2 ns |   386,941.6 |   1.2798 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,833.2 ns |   8,483.6 ns |    465.02 ns |   268.48 ns |  2,424.4 ns |   3,339.1 ns |   352,963.5 |   1.0910 | 0.0114 |    6.7 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  4,038.8 ns |   2,244.9 ns |    123.05 ns |    71.04 ns |  3,920.1 ns |   4,165.8 ns |   247,595.3 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  7,626.3 ns |   6,429.0 ns |    352.39 ns |   203.46 ns |  7,240.5 ns |   7,931.3 ns |   131,125.4 |   7.8125 | 0.0763 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 15,454.6 ns |   7,395.7 ns |    405.38 ns |   234.05 ns | 15,130.5 ns |  15,909.1 ns |    64,705.7 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 21,151.5 ns |  39,816.8 ns |  2,182.49 ns | 1,260.06 ns | 19,435.0 ns |  23,607.7 ns |    47,277.9 |   4.0283 | 0.1526 |  24.74 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 30,486.3 ns |  15,643.9 ns |    857.50 ns |   495.08 ns | 29,538.3 ns |  31,207.7 ns |    32,801.6 |   6.6528 | 0.4883 |  40.92 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 34,674.9 ns |  41,840.6 ns |  2,293.42 ns | 1,324.11 ns | 33,173.5 ns |  37,314.8 ns |    28,839.3 |   6.2866 | 0.3052 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 35,191.2 ns |  18,810.1 ns |  1,031.04 ns |   595.27 ns | 34,535.0 ns |  36,379.6 ns |    28,416.2 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 87,941.6 ns | 219,289.4 ns | 12,019.99 ns | 6,939.74 ns | 79,988.0 ns | 101,769.0 ns |    11,371.2 |  10.9863 | 0.8545 |  67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 98,669.5 ns |  19,543.4 ns |  1,071.24 ns |   618.48 ns | 97,684.7 ns |  99,810.1 ns |    10,134.8 | 195.4346 | 2.3193 | 1197.4 KB |
