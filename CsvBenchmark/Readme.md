# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     23.99 ms |     29.54 ms |     1.619 ms |   0.935 ms |     23.04 ms |     25.86 ms | 41.6802 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,774.08 ms |  5,627.64 ms |   308.470 ms | 178.095 ms |  3,423.44 ms |  4,003.65 ms |  0.2650 | 430000.0000 | 1000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 16,073.33 ms | 24,556.39 ms | 1,346.019 ms | 777.124 ms | 14,900.92 ms | 17,543.20 ms |  0.0622 | 432000.0000 | 3000.0000 | 1000.0000 |  9545.3 MB |
