# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr       | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     205.8 ns |      15.03 ns |      0.82 ns |      0.48 ns |     205.2 ns |     206.7 ns | 4,859,189.9 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     218.2 ns |      39.19 ns |      2.15 ns |      1.24 ns |     215.9 ns |     220.2 ns | 4,581,914.2 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,828.3 ns |      31.95 ns |      1.75 ns |      1.01 ns |   1,826.9 ns |   1,830.2 ns |   546,963.8 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,842.1 ns |     184.81 ns |     10.13 ns |      5.85 ns |   1,832.2 ns |   1,852.4 ns |   542,848.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,851.9 ns |     895.23 ns |     49.07 ns |     28.33 ns |   1,822.1 ns |   1,908.6 ns |   539,973.0 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,887.8 ns |     863.70 ns |     47.34 ns |     27.33 ns |   1,853.7 ns |   1,941.9 ns |   529,706.4 | 0.0591 |     248 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,899.9 ns |     731.27 ns |     40.08 ns |     23.14 ns |   1,856.6 ns |   1,935.7 ns |   526,338.9 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  18,015.6 ns |     300.55 ns |     16.47 ns |      9.51 ns |  17,996.6 ns |  18,026.2 ns |    55,507.4 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  18,032.5 ns |     284.43 ns |     15.59 ns |      9.00 ns |  18,014.7 ns |  18,043.9 ns |    55,455.6 | 0.0305 |     248 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  18,051.6 ns |     545.63 ns |     29.91 ns |     17.27 ns |  18,023.7 ns |  18,083.2 ns |    55,396.8 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  18,071.9 ns |   1,203.81 ns |     65.98 ns |     38.10 ns |  18,032.1 ns |  18,148.1 ns |    55,334.4 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  18,774.2 ns |   2,764.28 ns |    151.52 ns |     87.48 ns |  18,599.8 ns |  18,873.5 ns |    53,264.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 179,842.2 ns |   1,588.11 ns |     87.05 ns |     50.26 ns | 179,741.7 ns | 179,895.0 ns |     5,560.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 200,582.3 ns | 243,888.60 ns | 13,368.36 ns |  7,718.22 ns | 185,962.1 ns | 212,181.9 ns |     4,985.5 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 447,327.3 ns | 431,950.66 ns | 23,676.67 ns | 13,669.73 ns | 424,729.2 ns | 471,952.2 ns |     2,235.5 |      - |     128 B |
