# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error       | StdDev    | StdErr    | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|------------:|----------:|----------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   180.3 ns |    40.83 ns |   2.24 ns |   1.29 ns |   177.7 ns |   181.6 ns | 5,545,688.2 |  0.33 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   264.5 ns |   714.40 ns |  39.16 ns |  22.61 ns |   230.5 ns |   307.3 ns | 3,780,581.6 |  0.49 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 4     |   555.1 ns | 1,183.17 ns |  64.85 ns |  37.44 ns |   484.2 ns |   611.3 ns | 1,801,349.2 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   709.7 ns |   550.77 ns |  30.19 ns |  17.43 ns |   676.0 ns |   734.3 ns | 1,408,959.0 |  1.29 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     | 2,239.7 ns | 2,282.80 ns | 125.13 ns |  72.24 ns | 2,136.9 ns | 2,379.0 ns |   446,492.9 |  4.06 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 2,325.4 ns | 2,647.84 ns | 145.14 ns |  83.79 ns | 2,240.2 ns | 2,492.9 ns |   430,041.0 |  4.25 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 4     | 4,895.8 ns |   878.41 ns |  48.15 ns |  27.80 ns | 4,840.6 ns | 4,928.9 ns |   204,257.0 |  8.91 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 8,625.3 ns | 8,296.19 ns | 454.74 ns | 262.55 ns | 8,209.3 ns | 9,110.8 ns |   115,938.3 | 15.62 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
|              |              |       |            |             |           |           |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   184.3 ns |   135.09 ns |   7.40 ns |   4.28 ns |   178.1 ns |   192.5 ns | 5,425,648.6 |  0.37 |  0.6425 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   231.1 ns |    26.29 ns |   1.44 ns |   0.83 ns |   229.7 ns |   232.6 ns | 4,327,978.4 |  0.46 |  0.6657 |      - |   4.08 KB |        1.04 |
| Append       | Int32[1000]  | 101   |   504.6 ns |   566.20 ns |  31.04 ns |  17.92 ns |   485.5 ns |   540.4 ns | 1,981,733.5 |  1.00 |  0.6418 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   659.2 ns |   239.33 ns |  13.12 ns |   7.57 ns |   645.7 ns |   671.9 ns | 1,517,015.7 |  1.31 |  2.5673 | 0.0916 |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 2,104.8 ns | 1,170.33 ns |  64.15 ns |  37.04 ns | 2,045.6 ns | 2,173.0 ns |   475,097.1 |  4.19 |  6.3286 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 2,283.7 ns |   581.02 ns |  31.85 ns |  18.39 ns | 2,248.0 ns | 2,309.3 ns |   437,889.8 |  4.54 |  6.3667 |      - |  39.23 KB |        9.96 |
| Append       | Int32[10000] | 101   | 5,193.9 ns | 4,694.84 ns | 257.34 ns | 148.58 ns | 4,944.4 ns | 5,458.4 ns |   192,534.9 | 10.30 |  6.3248 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 8,253.3 ns | 6,795.10 ns | 372.46 ns | 215.04 ns | 7,940.8 ns | 8,665.4 ns |   121,163.9 | 16.37 | 25.4211 | 8.4534 | 156.36 KB |       39.71 |
