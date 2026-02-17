# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     22.77 ms |     10.99 ms |   0.602 ms |   0.348 ms |     22.10 ms |     23.26 ms | 43.9165 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  5,035.46 ms | 16,113.58 ms | 883.240 ms | 509.939 ms |  4,117.88 ms |  5,879.80 ms |  0.1986 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 13,316.80 ms |  6,609.98 ms | 362.316 ms | 209.183 ms | 12,905.49 ms | 13,588.70 ms |  0.0751 | 432000.0000 | 3000.0000 | 2000.0000 |  9545.3 MB |
