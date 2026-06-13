# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     28.85 ms |   172.40 ms |   9.450 ms |   5.456 ms |     21.67 ms |     39.55 ms | 34.6675 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,840.16 ms | 8,366.43 ms | 458.592 ms | 264.768 ms |  2,338.07 ms |  3,236.93 ms |  0.3521 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 13,435.32 ms | 7,924.24 ms | 434.355 ms | 250.775 ms | 13,060.91 ms | 13,911.54 ms |  0.0744 | 432000.0000 | 3000.0000 | 1000.0000 |  9545.3 MB |
