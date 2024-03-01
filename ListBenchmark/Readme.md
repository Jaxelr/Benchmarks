# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    443.0 ns |   1,112.2 ns |    60.96 ns |    35.20 ns |    376.7 ns |    496.5 ns | 2,257,090.2 |  0.1364 |       - |       - |     856 B |
| PreprovisionListSmallItem | 100   |    447.3 ns |   2,275.1 ns |   124.71 ns |    72.00 ns |    348.0 ns |    587.3 ns | 2,235,440.4 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |    601.6 ns |     952.7 ns |    52.22 ns |    30.15 ns |    541.6 ns |    637.0 ns | 1,662,314.1 |  0.3490 |  0.0010 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    702.0 ns |   1,029.0 ns |    56.40 ns |    32.56 ns |    636.9 ns |    735.5 ns | 1,424,477.7 |  0.3490 |       - |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 27,495.1 ns |  16,157.8 ns |   885.66 ns |   511.34 ns | 26,712.8 ns | 28,456.7 ns |    36,370.2 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 33,715.9 ns | 109,554.6 ns | 6,005.06 ns | 3,467.02 ns | 29,396.5 ns | 40,573.3 ns |    29,659.6 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListSmallItem     | 10000 | 88,376.8 ns | 136,881.4 ns | 7,502.93 ns | 4,331.82 ns | 82,955.7 ns | 96,939.9 ns |    11,315.2 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListLargeItem     | 10000 | 92,727.0 ns |  45,047.2 ns | 2,469.19 ns | 1,425.59 ns | 89,896.9 ns | 94,441.7 ns |    10,784.3 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
