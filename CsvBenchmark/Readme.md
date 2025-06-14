# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     56.04 ms |    159.09 ms |     8.720 ms |   5.035 ms |     46.42 ms |     63.42 ms | 17.8442 |   4000.0000 |         - |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,831.89 ms |  7,774.10 ms |   426.124 ms | 246.023 ms |  3,357.16 ms |  4,181.32 ms |  0.2610 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 14,842.25 ms | 21,065.80 ms | 1,154.688 ms | 666.659 ms | 13,872.13 ms | 16,119.43 ms |  0.0674 | 288000.0000 | 1000.0000 | 1000.0000 | 9545.28 MB |
