# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean         | Error        | StdDev       | StdErr      | Min         | Max          | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |-------------:|-------------:|-------------:|------------:|------------:|-------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |     250.9 ns |     125.5 ns |      6.88 ns |     3.97 ns |    245.1 ns |     258.5 ns | 3,985,491.1 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |     288.9 ns |     800.7 ns |     43.89 ns |    25.34 ns |    239.2 ns |     322.2 ns | 3,461,567.1 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |     465.4 ns |     302.4 ns |     16.58 ns |     9.57 ns |    449.2 ns |     482.3 ns | 2,148,855.8 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |     468.5 ns |     215.5 ns |     11.81 ns |     6.82 ns |    461.4 ns |     482.1 ns | 2,134,555.2 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 |  19,240.7 ns |   6,845.4 ns |    375.22 ns |   216.63 ns | 18,812.3 ns |  19,511.0 ns |    51,973.3 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 |  22,528.5 ns |  16,507.1 ns |    904.81 ns |   522.39 ns | 21,505.2 ns |  23,222.9 ns |    44,388.3 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 |  89,177.3 ns |  68,875.4 ns |  3,775.29 ns | 2,179.67 ns | 86,641.2 ns |  93,516.0 ns |    11,213.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 102,917.0 ns | 216,746.7 ns | 11,880.62 ns | 6,859.28 ns | 90,549.0 ns | 114,241.3 ns |     9,716.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
