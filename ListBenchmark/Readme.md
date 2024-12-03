# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    197.2 ns |     18.14 ns |     0.99 ns |     0.57 ns |    196.3 ns |    198.3 ns | 5,071,377.4 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    197.3 ns |     14.33 ns |     0.79 ns |     0.45 ns |    196.8 ns |    198.2 ns | 5,067,292.0 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    336.6 ns |     16.28 ns |     0.89 ns |     0.52 ns |    335.8 ns |    337.6 ns | 2,970,797.2 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    354.1 ns |    127.94 ns |     7.01 ns |     4.05 ns |    346.1 ns |    359.2 ns | 2,824,075.0 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 18,803.1 ns |  2,918.96 ns |   160.00 ns |    92.37 ns | 18,619.1 ns | 18,909.6 ns |    53,182.7 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 18,887.6 ns |  4,996.60 ns |   273.88 ns |   158.13 ns | 18,722.8 ns | 19,203.7 ns |    52,944.9 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 69,342.9 ns | 82,011.26 ns | 4,495.31 ns | 2,595.37 ns | 66,381.2 ns | 74,515.5 ns |    14,421.1 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 74,910.7 ns | 32,273.33 ns | 1,769.01 ns | 1,021.34 ns | 72,874.2 ns | 76,066.4 ns |    13,349.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
