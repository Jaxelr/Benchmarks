# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   180.7 ns |   101.55 ns |   5.57 ns |   3.21 ns |   175.9 ns |   186.8 ns | 5,535,487.0 |  0.27 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   200.1 ns |    25.79 ns |   1.41 ns |   0.82 ns |   199.1 ns |   201.8 ns | 4,996,527.8 |  0.30 |  0.6564 |      - |   4.02 KB |        1.02 |
| AppendToList | Int32[1000]  | 4     |   649.3 ns |    49.90 ns |   2.74 ns |   1.58 ns |   646.7 ns |   652.1 ns | 1,540,107.5 |  0.98 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| Append       | Int32[1000]  | 4     |   668.7 ns | 1,018.73 ns |  55.84 ns |  32.24 ns |   619.4 ns |   729.3 ns | 1,495,422.9 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[10000] | 4     | 2,187.8 ns |   334.39 ns |  18.33 ns |  10.58 ns | 2,173.5 ns | 2,208.4 ns |   457,085.0 |  3.29 |  6.3667 |      - |  39.18 KB |        9.95 |
| AppendCopyTo | Int32[10000] | 4     | 2,345.3 ns | 1,824.32 ns | 100.00 ns |  57.73 ns | 2,238.9 ns | 2,437.3 ns |   426,381.8 |  3.52 |  6.3286 |      - |  39.09 KB |        9.93 |
| Append       | Int32[10000] | 4     | 5,043.1 ns |   774.94 ns |  42.48 ns |  24.52 ns | 4,994.1 ns | 5,067.7 ns |   198,289.5 |  7.58 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,661.6 ns | 4,983.05 ns | 273.14 ns | 157.70 ns | 8,397.2 ns | 8,942.7 ns |   115,451.6 | 13.01 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   198.2 ns |   340.33 ns |  18.65 ns |  10.77 ns |   176.7 ns |   210.1 ns | 5,045,771.8 |  0.38 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   210.5 ns |   346.01 ns |  18.97 ns |  10.95 ns |   195.3 ns |   231.7 ns | 4,751,680.5 |  0.41 |  0.6564 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   515.4 ns |   249.03 ns |  13.65 ns |   7.88 ns |   500.0 ns |   526.0 ns | 1,940,360.6 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   752.9 ns | 1,877.42 ns | 102.91 ns |  59.41 ns |   677.3 ns |   870.1 ns | 1,328,244.1 |  1.46 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,222.7 ns |   670.41 ns |  36.75 ns |  21.22 ns | 2,195.9 ns | 2,264.6 ns |   449,894.6 |  4.31 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,310.7 ns | 1,362.95 ns |  74.71 ns |  43.13 ns | 2,251.5 ns | 2,394.7 ns |   432,764.4 |  4.49 |  6.3667 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 4,945.7 ns |   218.41 ns |  11.97 ns |   6.91 ns | 4,932.5 ns | 4,955.9 ns |   202,197.8 |  9.60 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,602.8 ns | 2,327.06 ns | 127.55 ns |  73.64 ns | 8,455.7 ns | 8,682.5 ns |   116,241.4 | 16.70 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
