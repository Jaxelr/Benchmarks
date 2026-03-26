# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     214.6 ns |     12.50 ns |     0.69 ns |     0.40 ns |     214.0 ns |     215.3 ns | 4,660,757.1 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     214.6 ns |      1.45 ns |     0.08 ns |     0.05 ns |     214.6 ns |     214.7 ns | 4,659,299.4 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,165.0 ns |     56.09 ns |     3.07 ns |     1.77 ns |   2,161.6 ns |   2,167.5 ns |   461,897.4 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,165.6 ns |     94.98 ns |     5.21 ns |     3.01 ns |   2,159.8 ns |   2,169.8 ns |   461,767.6 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,171.8 ns |    100.25 ns |     5.49 ns |     3.17 ns |   2,166.1 ns |   2,177.0 ns |   460,443.8 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,179.3 ns |     17.11 ns |     0.94 ns |     0.54 ns |   2,178.6 ns |   2,180.4 ns |   458,857.9 | 0.0591 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,183.8 ns |     37.49 ns |     2.05 ns |     1.19 ns |   2,181.8 ns |   2,185.9 ns |   457,915.8 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  21,365.3 ns |    502.18 ns |    27.53 ns |    15.89 ns |  21,333.9 ns |  21,385.2 ns |    46,804.8 |      - |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  21,372.8 ns |    770.67 ns |    42.24 ns |    24.39 ns |  21,324.0 ns |  21,398.6 ns |    46,788.5 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  21,687.1 ns | 14,147.36 ns |   775.46 ns |   447.71 ns |  21,229.4 ns |  22,582.5 ns |    46,110.3 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  21,890.9 ns |    230.39 ns |    12.63 ns |     7.29 ns |  21,883.3 ns |  21,905.5 ns |    45,681.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  22,250.7 ns | 28,712.89 ns | 1,573.85 ns |   908.66 ns |  21,306.4 ns |  24,067.6 ns |    44,942.4 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 212,285.0 ns |  3,047.03 ns |   167.02 ns |    96.43 ns | 212,092.6 ns | 212,393.1 ns |     4,710.6 |      - |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 213,397.0 ns |  3,682.01 ns |   201.82 ns |   116.52 ns | 213,169.2 ns | 213,553.7 ns |     4,686.1 |      - |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 214,944.3 ns | 34,083.82 ns | 1,868.25 ns | 1,078.63 ns | 212,943.0 ns | 216,642.4 ns |     4,652.4 |      - |      64 B |
