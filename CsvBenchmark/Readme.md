# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min         | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     28.73 ms |     27.83 ms |     1.525 ms |   0.881 ms |    27.00 ms |     29.90 ms | 34.8078 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,048.52 ms |  4,580.39 ms |   251.066 ms | 144.953 ms | 2,804.06 ms |  3,305.71 ms |  0.3280 | 430000.0000 | 1000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 10,263.37 ms | 20,733.92 ms | 1,136.496 ms | 656.156 ms | 9,248.04 ms | 11,491.07 ms |  0.0974 | 431000.0000 | 2000.0000 | 1000.0000 | 9545.29 MB |
