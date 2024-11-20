# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     43.15 ms |     62.84 ms |     3.445 ms |   1.989 ms |     39.23 ms |     45.71 ms | 23.1746 |   4000.0000 |         - |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,548.07 ms |  2,790.87 ms |   152.977 ms |  88.321 ms |  2,375.35 ms |  2,666.51 ms |  0.3925 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,617.36 ms | 30,541.74 ms | 1,674.096 ms | 966.540 ms | 10,240.96 ms | 13,481.04 ms |  0.0861 | 288000.0000 | 1000.0000 | 1000.0000 | 9545.28 MB |
