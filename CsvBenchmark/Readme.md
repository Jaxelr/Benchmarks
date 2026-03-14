# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.200
  [Host]   : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.4 (10.0.4, 10.0.426.12010), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     33.70 ms |     34.96 ms |     1.916 ms |   1.106 ms |     31.61 ms |     35.36 ms | 29.6692 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,093.37 ms |  3,874.13 ms |   212.354 ms | 122.603 ms |  2,951.32 ms |  3,337.49 ms |  0.3233 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 17,782.73 ms | 20,655.16 ms | 1,132.179 ms | 653.664 ms | 16,475.92 ms | 18,468.03 ms |  0.0562 | 432000.0000 | 3000.0000 | 1000.0000 | 9545.29 MB |
