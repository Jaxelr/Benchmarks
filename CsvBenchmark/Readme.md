# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]   : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     29.80 ms |    42.52 ms |   2.330 ms |   1.346 ms |     27.20 ms |     31.71 ms | 33.5549 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,655.18 ms | 2,227.96 ms | 122.122 ms |  70.507 ms |  2,552.59 ms |  2,790.26 ms |  0.3766 | 430000.0000 | 1000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,338.63 ms | 4,829.79 ms | 264.737 ms | 152.846 ms | 11,182.15 ms | 11,644.29 ms |  0.0882 | 432000.0000 | 3000.0000 | 1000.0000 |  9545.3 MB |
