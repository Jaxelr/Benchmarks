# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    214.5 ns |     147.3 ns |     8.08 ns |     4.66 ns |    207.9 ns |    223.5 ns | 4,662,368.3 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListSmallItem | 100   |    235.4 ns |   1,016.3 ns |    55.71 ns |    32.16 ns |    201.0 ns |    299.7 ns | 4,247,630.5 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    382.0 ns |     271.0 ns |    14.85 ns |     8.57 ns |    371.5 ns |    399.0 ns | 2,617,768.6 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    510.0 ns |     108.3 ns |     5.94 ns |     3.43 ns |    503.2 ns |    514.1 ns | 1,960,651.6 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 23,480.3 ns |   1,941.9 ns |   106.44 ns |    61.45 ns | 23,372.2 ns | 23,585.1 ns |    42,588.8 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 28,857.4 ns | 105,209.2 ns | 5,766.87 ns | 3,329.50 ns | 24,643.7 ns | 35,429.7 ns |    34,653.2 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 72,684.8 ns |  43,649.5 ns | 2,392.58 ns | 1,381.35 ns | 70,167.0 ns | 74,928.6 ns |    13,758.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 77,186.5 ns | 125,790.0 ns | 6,894.98 ns | 3,980.82 ns | 69,745.6 ns | 83,359.7 ns |    12,955.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
