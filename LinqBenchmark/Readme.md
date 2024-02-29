# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error           | StdDev       | StdErr       | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|----------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     275.4 ns |       843.39 ns |     46.23 ns |     26.69 ns |     243.1 ns |     328.4 ns | 3,631,134.7 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     490.5 ns |        66.61 ns |      3.65 ns |      2.11 ns |     487.0 ns |     494.3 ns | 2,038,936.3 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,364.2 ns |     1,427.46 ns |     78.24 ns |     45.17 ns |   1,282.7 ns |   1,438.7 ns |   733,044.7 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,443.3 ns |     1,997.65 ns |    109.50 ns |     63.22 ns |   1,359.0 ns |   1,567.0 ns |   692,867.8 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,578.8 ns |     2,565.56 ns |    140.63 ns |     81.19 ns |   1,420.6 ns |   1,689.7 ns |   633,383.6 | 0.0191 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,834.8 ns |     6,890.85 ns |    377.71 ns |    218.07 ns |   1,406.8 ns |   2,121.3 ns |   545,007.2 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   3,191.4 ns |    21,561.72 ns |  1,181.87 ns |    682.35 ns |   2,137.5 ns |   4,469.2 ns |   313,345.0 | 0.0381 |     256 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  12,780.7 ns |    11,339.40 ns |    621.55 ns |    358.85 ns |  12,358.6 ns |  13,494.4 ns |    78,243.0 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  13,129.7 ns |    13,172.18 ns |    722.01 ns |    416.85 ns |  12,477.5 ns |  13,905.6 ns |    76,163.1 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  14,835.3 ns |    20,507.86 ns |  1,124.10 ns |    649.00 ns |  13,570.0 ns |  15,718.7 ns |    67,406.9 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  20,319.2 ns |    63,328.05 ns |  3,471.22 ns |  2,004.11 ns |  16,725.9 ns |  23,653.9 ns |    49,214.5 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  22,566.8 ns |    31,901.48 ns |  1,748.63 ns |  1,009.57 ns |  21,354.7 ns |  24,571.3 ns |    44,313.0 |      - |     256 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 134,647.7 ns |   283,389.15 ns | 15,533.52 ns |  8,968.28 ns | 125,378.5 ns | 152,580.8 ns |     7,426.8 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 219,378.8 ns |   336,835.49 ns | 18,463.09 ns | 10,659.67 ns | 198,704.3 ns | 234,222.8 ns |     4,558.3 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 609,148.9 ns | 1,046,565.81 ns | 57,365.80 ns | 33,120.16 ns | 554,953.8 ns | 669,231.3 ns |     1,641.6 |      - |     128 B |
