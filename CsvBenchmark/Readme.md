# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s    | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |     47.06 ms |    128.56 ms |     7.047 ms |     4.069 ms |     40.41 ms |     54.45 ms | 21.2472 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  3,975.55 ms |  5,902.57 ms |   323.540 ms |   186.796 ms |  3,606.20 ms |  4,208.84 ms |  0.2515 | 288000.0000 |         - |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 23,889.11 ms | 34,007.87 ms | 1,864.086 ms | 1,076.231 ms | 21,801.43 ms | 25,386.84 ms |  0.0419 | 295000.0000 | 6000.0000 | 2000.0000 | 9568.95 MB |
