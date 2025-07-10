# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error     | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|----------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   171.6 ns |  46.35 ns |  2.54 ns |  1.47 ns |   168.7 ns |   173.2 ns | 5,827,836.5 |  0.36 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   198.6 ns |  43.32 ns |  2.37 ns |  1.37 ns |   196.2 ns |   200.9 ns | 5,035,334.6 |  0.41 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   481.4 ns | 101.78 ns |  5.58 ns |  3.22 ns |   477.1 ns |   487.7 ns | 2,077,479.8 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   644.1 ns | 165.25 ns |  9.06 ns |  5.23 ns |   637.2 ns |   654.4 ns | 1,552,456.5 |  1.34 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,052.5 ns | 574.37 ns | 31.48 ns | 18.18 ns | 2,016.3 ns | 2,073.8 ns |   487,219.3 |  4.26 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,202.5 ns | 738.58 ns | 40.48 ns | 23.37 ns | 2,175.3 ns | 2,249.0 ns |   454,033.7 |  4.58 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 4,964.9 ns | 963.86 ns | 52.83 ns | 30.50 ns | 4,919.9 ns | 5,023.1 ns |   201,412.9 | 10.32 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,117.9 ns | 904.52 ns | 49.58 ns | 28.62 ns | 8,063.0 ns | 8,159.4 ns |   123,184.2 | 16.87 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |           |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   172.5 ns | 108.77 ns |  5.96 ns |  3.44 ns |   168.4 ns |   179.3 ns | 5,797,560.6 |  0.33 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   224.2 ns | 285.38 ns | 15.64 ns |  9.03 ns |   210.5 ns |   241.3 ns | 4,459,335.8 |  0.44 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   515.3 ns | 260.34 ns | 14.27 ns |  8.24 ns |   502.5 ns |   530.7 ns | 1,940,515.8 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   663.6 ns | 343.83 ns | 18.85 ns | 10.88 ns |   649.2 ns |   684.9 ns | 1,506,988.5 |  1.29 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,063.3 ns | 188.99 ns | 10.36 ns |  5.98 ns | 2,053.8 ns | 2,074.4 ns |   484,651.0 |  4.01 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,198.2 ns | 217.72 ns | 11.93 ns |  6.89 ns | 2,187.0 ns | 2,210.7 ns |   454,920.3 |  4.27 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,817.3 ns | 142.42 ns |  7.81 ns |  4.51 ns | 4,808.6 ns | 4,823.8 ns |   207,586.2 |  9.35 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,045.1 ns | 628.19 ns | 34.43 ns | 19.88 ns | 8,011.3 ns | 8,080.1 ns |   124,299.8 | 15.62 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
