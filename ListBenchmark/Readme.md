# List sample benchmarks

This is a benchmark test using different types of methods for a list of strings.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Size  | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0    | Gen1    | Gen2    | Allocated |
|-------------------------- |------ |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|--------:|--------:|--------:|----------:|
| PreprovisionListSmallItem | 100   |    198.2 ns |     43.84 ns |   2.40 ns |   1.39 ns |    195.9 ns |    200.7 ns | 5,046,673.9 |  0.1364 |  0.0002 |       - |     856 B |
| PreprovisionListLargeItem | 100   |    219.4 ns |    200.98 ns |  11.02 ns |   6.36 ns |    206.9 ns |    227.5 ns | 4,557,354.8 |  0.1364 |  0.0002 |       - |     856 B |
| AllocateListLargeItem     | 100   |    333.4 ns |     13.08 ns |   0.72 ns |   0.41 ns |    332.6 ns |    333.9 ns | 2,999,453.4 |  0.3490 |  0.0014 |       - |    2192 B |
| AllocateListSmallItem     | 100   |    383.2 ns |    351.40 ns |  19.26 ns |  11.12 ns |    371.9 ns |    405.5 ns | 2,609,274.8 |  0.3490 |  0.0014 |       - |    2192 B |
| PreprovisionListSmallItem | 10000 | 18,603.8 ns |  1,565.80 ns |  85.83 ns |  49.55 ns | 18,524.9 ns | 18,695.2 ns |    53,752.4 | 12.6343 |  2.5024 |       - |   80056 B |
| PreprovisionListLargeItem | 10000 | 18,824.3 ns |  4,299.96 ns | 235.70 ns | 136.08 ns | 18,628.6 ns | 19,085.9 ns |    53,122.7 | 12.6343 |  2.5024 |       - |   80056 B |
| AllocateListLargeItem     | 10000 | 67,075.6 ns | 16,677.83 ns | 914.17 ns | 527.80 ns | 66,535.0 ns | 68,131.1 ns |    14,908.5 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
| AllocateListSmallItem     | 10000 | 67,441.7 ns |  7,797.75 ns | 427.42 ns | 246.77 ns | 67,032.3 ns | 67,885.1 ns |    14,827.6 | 41.6260 | 41.6260 | 41.6260 |  262470 B |
