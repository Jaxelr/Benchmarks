# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     36.46 ms |     54.88 ms |   3.008 ms |   1.737 ms |     33.46 ms |     39.47 ms | 27.4310 |   4000.0000 |         - |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,267.08 ms |  7,753.44 ms | 424.992 ms | 245.369 ms |  2,865.21 ms |  3,711.93 ms |  0.3061 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 13,447.05 ms | 10,066.13 ms | 551.758 ms | 318.558 ms | 13,003.95 ms | 14,065.07 ms |  0.0744 | 289000.0000 | 2000.0000 | 1000.0000 | 9545.28 MB |

