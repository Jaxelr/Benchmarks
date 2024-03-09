# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          |  2.289 ns |  5.295 ns | 0.2902 ns | 0.1676 ns |  1.953 ns |  2.460 ns | 436,950,973.4 |  0.49 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          |  4.646 ns |  3.333 ns | 0.1827 ns | 0.1055 ns |  4.435 ns |  4.754 ns | 215,236,854.9 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 16.425 ns | 45.506 ns | 2.4943 ns | 1.4401 ns | 13.544 ns | 17.866 ns |  60,883,980.3 |  3.52 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |               |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX |  3.022 ns | 11.871 ns | 0.6507 ns | 0.3757 ns |  2.347 ns |  3.645 ns | 330,860,969.2 |  0.82 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX |  3.705 ns |  5.257 ns | 0.2881 ns | 0.1664 ns |  3.481 ns |  4.030 ns | 269,896,550.0 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 12.482 ns | 43.893 ns | 2.4059 ns | 1.3890 ns | 11.078 ns | 15.261 ns |  80,112,213.9 |  3.39 | 0.0051 |      32 B |          NA |
