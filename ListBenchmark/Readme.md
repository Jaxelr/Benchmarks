# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListLargeItem | 100   |    200.6 ns |     68.38 ns |     3.75 ns |   2.16 ns |    197.6 ns |    204.8 ns | 4,985,822.0 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListSmallItem | 100   |    224.1 ns |    286.08 ns |    15.68 ns |   9.05 ns |    214.8 ns |    242.2 ns | 4,461,504.9 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListSmallItem     | 100   |    386.3 ns |     93.44 ns |     5.12 ns |   2.96 ns |    382.6 ns |    392.1 ns | 2,588,650.1 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListLargeItem     | 100   |    390.6 ns |    690.96 ns |    37.87 ns |  21.87 ns |    349.8 ns |    424.5 ns | 2,559,923.9 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListLargeItem | 10000 | 19,371.5 ns | 13,063.81 ns |   716.07 ns | 413.42 ns | 18,681.7 ns | 20,111.2 ns |    51,622.2 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListSmallItem | 10000 | 20,186.7 ns | 24,295.66 ns | 1,331.73 ns | 768.87 ns | 19,151.5 ns | 21,689.0 ns |    49,537.6 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 67,342.4 ns | 17,003.90 ns |   932.04 ns | 538.11 ns | 66,461.9 ns | 68,318.6 ns |    14,849.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 67,522.9 ns | 25,422.15 ns | 1,393.47 ns | 804.52 ns | 66,033.0 ns | 68,794.1 ns |    14,809.8 | 41.6260 | 41.6260 | 41.6260 |  262472 B |
