# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     30.62 ms |     18.92 ms |     1.037 ms |     0.599 ms |     29.61 ms |     31.69 ms | 32.6558 |   6000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,754.31 ms |  1,661.70 ms |    91.083 ms |    52.587 ms |  3,684.82 ms |  3,857.43 ms |  0.2664 | 429000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 15,087.65 ms | 55,284.57 ms | 3,030.334 ms | 1,749.564 ms | 11,601.36 ms | 17,090.15 ms |  0.0663 | 431000.0000 | 2000.0000 | 1000.0000 | 9545.29 MB |
