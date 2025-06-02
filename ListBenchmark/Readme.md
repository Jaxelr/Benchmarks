# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error         | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|--------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    206.5 ns |      45.11 ns |     2.47 ns |     1.43 ns |    204.5 ns |    209.3 ns | 4,841,944.6 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    207.7 ns |      78.02 ns |     4.28 ns |     2.47 ns |    202.9 ns |    211.1 ns | 4,815,426.7 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListSmallItem     | 100   |    360.0 ns |      64.10 ns |     3.51 ns |     2.03 ns |    355.9 ns |    362.4 ns | 2,777,951.6 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListLargeItem     | 100   |    363.9 ns |     439.87 ns |    24.11 ns |    13.92 ns |    346.8 ns |    391.5 ns | 2,748,083.5 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 21,913.8 ns |   6,814.75 ns |   373.54 ns |   215.66 ns | 21,505.4 ns | 22,238.2 ns |    45,633.4 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 22,287.3 ns |  57,774.59 ns | 3,166.82 ns | 1,828.36 ns | 19,051.4 ns | 25,380.2 ns |    44,868.6 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 71,484.9 ns |  33,866.22 ns | 1,856.32 ns | 1,071.75 ns | 70,009.1 ns | 73,569.1 ns |    13,989.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 76,884.3 ns | 116,262.74 ns | 6,372.75 ns | 3,679.31 ns | 72,314.0 ns | 84,164.0 ns |    13,006.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
