# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     32.81 ms |     58.71 ms |     3.218 ms |     1.858 ms |     29.23 ms |     35.45 ms | 30.4739 |   4000.0000 |         - |         - |   25.48 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,298.47 ms |  1,505.65 ms |    82.530 ms |    47.649 ms |  2,240.45 ms |  2,392.95 ms |  0.4351 | 288000.0000 |         - |         - | 2400.29 MB |
| GenerateCsv | Syste(...)mple] [55] | 11,440.07 ms | 34,471.02 ms | 1,889.473 ms | 1,090.888 ms | 10,330.78 ms | 13,621.74 ms |  0.0874 | 292000.0000 | 2000.0000 | 1000.0000 | 9568.93 MB |
