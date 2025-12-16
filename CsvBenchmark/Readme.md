# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min         | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     22.15 ms |     69.04 ms |     3.784 ms |   2.185 ms |    19.19 ms |     26.41 ms | 45.1566 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,191.98 ms |    548.66 ms |    30.074 ms |  17.363 ms | 2,157.37 ms |  2,211.71 ms |  0.4562 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 10,816.56 ms | 24,245.29 ms | 1,328.966 ms | 767.279 ms | 9,803.78 ms | 12,321.38 ms |  0.0925 | 432000.0000 | 3000.0000 | 2000.0000 |  9545.3 MB |
