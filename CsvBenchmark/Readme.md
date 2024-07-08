# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.


```
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3810/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error         | StdDev        | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Allocated  |
|------------ |--------------------- |-------------:|--------------:|--------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     59.19 ms |     128.31 ms |      7.033 ms |     4.061 ms |     51.18 ms |     64.37 ms | 16.8961 |   4000.0000 |         - |    24.3 MB |
| GenerateCsv | Syste(...)mple] [55] |  4,822.42 ms |   4,778.51 ms |    261.926 ms |   151.223 ms |  4,523.55 ms |  5,012.01 ms |  0.2074 | 288000.0000 | 2000.0000 | 2388.47 MB |
| GenerateCsv | Syste(...)mple] [55] | 56,587.43 ms | 309,372.77 ms | 16,957.765 ms | 9,790.570 ms | 37,013.10 ms | 66,821.67 ms |  0.0177 | 289000.0000 | 2000.0000 | 9545.28 MB |
