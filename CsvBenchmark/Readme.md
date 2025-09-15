# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     23.89 ms |     13.60 ms |     0.745 ms |     0.430 ms |     23.11 ms |     24.59 ms | 41.8634 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,960.20 ms |  7,769.31 ms |   425.862 ms |   245.872 ms |  3,469.48 ms |  4,232.98 ms |  0.2525 | 430000.0000 | 1000.0000 |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 15,600.25 ms | 43,044.57 ms | 2,359.418 ms | 1,362.211 ms | 13,371.38 ms | 18,071.50 ms |  0.0641 | 433000.0000 | 4000.0000 | 2000.0000 |  9545.3 MB |
