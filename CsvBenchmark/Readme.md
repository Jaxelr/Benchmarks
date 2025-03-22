# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     40.68 ms |    129.53 ms |   7.100 ms |   4.099 ms |     34.07 ms |     48.18 ms | 24.5809 |   4000.0000 |         - |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,187.85 ms |  7,495.08 ms | 410.831 ms | 237.193 ms |  3,813.23 ms |  4,627.20 ms |  0.2388 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 15,138.49 ms | 12,071.39 ms | 661.673 ms | 382.017 ms | 14,401.18 ms | 15,680.60 ms |  0.0661 | 291000.0000 | 4000.0000 | 1000.0000 | 9545.28 MB |
