# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    196.6 ns |     17.89 ns |     0.98 ns |     0.57 ns |    195.5 ns |    197.4 ns | 5,087,532.0 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    210.0 ns |     23.61 ns |     1.29 ns |     0.75 ns |    208.8 ns |    211.4 ns | 4,762,070.1 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    329.3 ns |     13.08 ns |     0.72 ns |     0.41 ns |    328.7 ns |    330.1 ns | 3,036,544.8 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    344.1 ns |     41.35 ns |     2.27 ns |     1.31 ns |    342.2 ns |    346.6 ns | 2,905,813.2 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 18,547.9 ns |  3,928.54 ns |   215.34 ns |   124.32 ns | 18,381.0 ns | 18,791.0 ns |    53,914.5 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 18,881.2 ns |  6,043.03 ns |   331.24 ns |   191.24 ns | 18,636.3 ns | 19,258.1 ns |    52,962.8 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 71,858.1 ns | 15,559.70 ns |   852.88 ns |   492.41 ns | 71,085.4 ns | 72,773.3 ns |    13,916.3 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 76,332.0 ns | 39,339.06 ns | 2,156.31 ns | 1,244.94 ns | 74,799.9 ns | 78,797.8 ns |    13,100.7 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
