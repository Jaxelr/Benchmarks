# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    192.0 ns |      9.35 ns |   0.51 ns |   0.30 ns |    191.4 ns |    192.4 ns | 5,209,659.8 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListSmallItem | 100   |    193.2 ns |      9.13 ns |   0.50 ns |   0.29 ns |    192.8 ns |    193.7 ns | 5,177,143.0 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    341.3 ns |     35.61 ns |   1.95 ns |   1.13 ns |    339.4 ns |    343.3 ns | 2,929,685.7 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    347.3 ns |     83.97 ns |   4.60 ns |   2.66 ns |    343.2 ns |    352.3 ns | 2,879,348.1 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 18,462.8 ns |  1,282.36 ns |  70.29 ns |  40.58 ns | 18,414.5 ns | 18,543.4 ns |    54,163.0 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 18,734.9 ns |  4,989.26 ns | 273.48 ns | 157.89 ns | 18,419.1 ns | 18,893.9 ns |    53,376.3 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 66,935.8 ns | 14,477.63 ns | 793.57 ns | 458.17 ns | 66,096.3 ns | 67,673.7 ns |    14,939.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 66,971.9 ns |  4,903.16 ns | 268.76 ns | 155.17 ns | 66,695.8 ns | 67,232.6 ns |    14,931.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
