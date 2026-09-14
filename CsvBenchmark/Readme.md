# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9445/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     23.88 ms |     59.40 ms |     3.256 ms |   1.880 ms |     20.15 ms |     26.19 ms | 41.8814 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,124.22 ms |  9,351.88 ms |   512.608 ms | 295.954 ms |  2,534.13 ms |  3,459.43 ms |  0.3201 | 430000.0000 | 1000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 12,152.55 ms | 21,073.56 ms | 1,155.113 ms | 666.905 ms | 11,164.72 ms | 13,422.63 ms |  0.0823 | 432000.0000 | 3000.0000 | 2000.0000 | 9545.29 MB |
