# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean         | Error       | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |-------------:|------------:|------------:|------------:|-------------:|-------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |     282.7 ns |    105.2 ns |     5.76 ns |     3.33 ns |     278.1 ns |     289.2 ns | 3,537,450.2 |  0.1364 |       - |       - |     856 B |
| PreprovisionListLargeItem | 100   |     333.2 ns |    666.6 ns |    36.54 ns |    21.10 ns |     306.6 ns |     374.8 ns | 3,001,361.3 |  0.1364 |       - |       - |     856 B |
| AllocateListLargeItem     | 100   |     551.0 ns |    382.6 ns |    20.97 ns |    12.11 ns |     530.4 ns |     572.4 ns | 1,814,759.5 |  0.3490 |  0.0010 |       - |    2192 B |
| AllocateListSmallItem     | 100   |     827.4 ns |  2,530.5 ns |   138.71 ns |    80.08 ns |     670.8 ns |     934.8 ns | 1,208,583.2 |  0.3490 |  0.0010 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 |  24,281.9 ns | 21,562.8 ns | 1,181.93 ns |   682.39 ns |  22,948.1 ns |  25,199.2 ns |    41,182.9 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 |  24,789.7 ns | 12,373.3 ns |   678.22 ns |   391.57 ns |  24,007.1 ns |  25,204.5 ns |    40,339.3 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 |  79,674.0 ns |  8,698.3 ns |   476.78 ns |   275.27 ns |  79,273.0 ns |  80,201.2 ns |    12,551.1 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 111,731.7 ns | 91,525.4 ns | 5,016.81 ns | 2,896.46 ns | 106,391.1 ns | 116,345.5 ns |     8,950.0 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
