# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr     | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-----------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     38.32 ms |     47.27 ms |     2.591 ms |   1.496 ms |     36.63 ms |     41.30 ms | 26.0957 |   4000.0000 |         - |         - |   24.31 MB |
| GenerateCsv | Syste(...)mple] [55] |  2,692.62 ms |  4,849.50 ms |   265.817 ms | 153.470 ms |  2,425.34 ms |  2,956.95 ms |  0.3714 | 286000.0000 |         - |         - | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 19,670.72 ms | 20,990.03 ms | 1,150.534 ms | 664.261 ms | 18,342.27 ms | 20,346.87 ms |  0.0508 | 292000.0000 | 6000.0000 | 2000.0000 |  9545.3 MB |
