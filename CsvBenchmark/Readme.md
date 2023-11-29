# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean        | Error       | StdDev    | StdErr     | Min         | Max         | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |------------:|------------:|----------:|-----------:|------------:|------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |    36.16 ms |   263.02 ms |  14.42 ms |   8.324 ms |    26.60 ms |    52.74 ms | 27.6571 |   4000.0000 |         - |         - |   25.48 MB |
| GenerateCsv | Syste(...)mple] [55] | 1,969.52 ms | 3,816.87 ms | 209.22 ms | 120.791 ms | 1,820.57 ms | 2,208.71 ms |  0.5077 | 288000.0000 |         - |         - | 2400.29 MB |
| GenerateCsv | Syste(...)mple] [55] | 8,422.72 ms | 2,887.73 ms | 158.29 ms |  91.387 ms | 8,321.77 ms | 8,605.15 ms |  0.1187 | 292000.0000 | 2000.0000 | 1000.0000 | 9568.93 MB |
