# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev    | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     60.47 ms |    308.14 ms |  16.89 ms |   9.751 ms |     49.60 ms |     79.93 ms | 16.5370 |   4000.0000 |         - |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,503.04 ms | 12,784.41 ms | 700.76 ms | 404.582 ms |  2,697.85 ms |  3,975.03 ms |  0.2855 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 13,534.91 ms |  3,551.53 ms | 194.67 ms | 112.394 ms | 13,336.98 ms | 13,726.15 ms |  0.0739 | 288000.0000 | 1000.0000 | 1000.0000 | 9545.28 MB |
