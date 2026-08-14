# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3
LaunchCount=1  UnrollFactor=1  WarmupCount=3

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     31.20 ms |     81.07 ms |   4.444 ms |   2.566 ms |     27.29 ms |     36.03 ms | 32.0546 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,133.79 ms | 10,703.57 ms | 586.699 ms | 338.731 ms |  2,456.37 ms |  3,479.01 ms |  0.3191 | 431000.0000 | 3000.0000 | 2000.0000 | 2388.49 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,320.58 ms |  3,844.14 ms | 210.710 ms | 121.654 ms | 11,092.41 ms | 11,507.83 ms |  0.0883 | 432000.0000 | 3000.0000 | 1000.0000 |  9545.3 MB |
