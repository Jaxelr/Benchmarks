# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4770/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev     | StdErr     | Min         | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-----------:|-----------:|------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     22.22 ms |     22.60 ms |   1.239 ms |   0.715 ms |    20.80 ms |     23.06 ms | 45.0071 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,606.62 ms |  3,772.45 ms | 206.781 ms | 119.385 ms | 2,400.76 ms |  2,814.31 ms |  0.3836 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 10,616.51 ms | 10,087.07 ms | 552.906 ms | 319.220 ms | 9,985.73 ms | 11,017.29 ms |  0.0942 | 431000.0000 | 2000.0000 | 1000.0000 |  9545.3 MB |
