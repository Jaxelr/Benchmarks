# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error         | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     87.05 ms |      64.85 ms |     3.555 ms |     2.052 ms |     84.57 ms |     91.13 ms | 11.4873 |   4000.0000 |         - |         - |   25.48 MB |
| GenerateCsv | Syste(...)mple] [55] |  8,122.63 ms |  24,079.08 ms | 1,319.856 ms |   762.019 ms |  6,731.78 ms |  9,357.65 ms |  0.1231 | 288000.0000 |         - |         - | 2400.29 MB |
| GenerateCsv | Syste(...)mple] [55] | 31,070.66 ms | 163,872.97 ms | 8,982.431 ms | 5,186.009 ms | 25,760.40 ms | 41,441.68 ms |  0.0322 | 294000.0000 | 4000.0000 | 1000.0000 | 9568.94 MB |
