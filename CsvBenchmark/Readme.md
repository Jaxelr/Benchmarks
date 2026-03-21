# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     36.15 ms |    152.40 ms |     8.354 ms |     4.823 ms |     27.04 ms |     43.46 ms | 27.6634 |   6000.0000 |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,223.95 ms |  5,411.08 ms |   296.600 ms |   171.242 ms |  2,901.28 ms |  3,484.70 ms |  0.3102 | 429000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 17,423.18 ms | 40,150.66 ms | 2,200.793 ms | 1,270.629 ms | 14,919.40 ms | 19,051.63 ms |  0.0574 | 433000.0000 | 4000.0000 | 9545.29 MB |
