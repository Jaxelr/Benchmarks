# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     37.87 ms |     42.35 ms |   2.321 ms |   1.340 ms |     36.35 ms |     40.55 ms | 26.4033 |   4000.0000 |         - |         - |   25.48 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,083.05 ms |  4,956.07 ms | 271.659 ms | 156.842 ms |  1,838.87 ms |  2,375.67 ms |  0.4801 | 288000.0000 |         - |         - | 2400.29 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,832.27 ms | 12,815.36 ms | 702.453 ms | 405.562 ms | 11,040.43 ms | 12,380.44 ms |  0.0845 | 294000.0000 | 3000.0000 | 1000.0000 | 9568.94 MB |
