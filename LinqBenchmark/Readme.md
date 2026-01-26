# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     183.5 ns |      17.02 ns |     0.93 ns |     0.54 ns |     182.8 ns |     184.6 ns | 5,448,687.1 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     185.9 ns |      14.58 ns |     0.80 ns |     0.46 ns |     185.4 ns |     186.9 ns | 5,378,139.8 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   1,896.8 ns |     832.70 ns |    45.64 ns |    26.35 ns |   1,851.7 ns |   1,942.9 ns |   527,207.4 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   1,901.0 ns |     174.53 ns |     9.57 ns |     5.52 ns |   1,891.4 ns |   1,910.5 ns |   526,045.4 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   1,998.9 ns |     869.30 ns |    47.65 ns |    27.51 ns |   1,959.1 ns |   2,051.7 ns |   500,281.0 | 0.0572 |     248 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,003.7 ns |   1,706.06 ns |    93.52 ns |    53.99 ns |   1,896.3 ns |   2,067.0 ns |   499,067.4 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,146.9 ns |   1,197.28 ns |    65.63 ns |    37.89 ns |   2,071.9 ns |   2,193.9 ns |   465,798.5 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  18,398.0 ns |   3,544.77 ns |   194.30 ns |   112.18 ns |  18,275.6 ns |  18,622.0 ns |    54,353.8 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  18,856.2 ns |   2,298.11 ns |   125.97 ns |    72.73 ns |  18,723.4 ns |  18,973.9 ns |    53,032.8 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  19,420.0 ns |  27,139.25 ns | 1,487.59 ns |   858.86 ns |  18,332.4 ns |  21,115.2 ns |    51,493.3 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  20,146.2 ns |  17,229.89 ns |   944.43 ns |   545.27 ns |  19,268.2 ns |  21,145.3 ns |    49,637.2 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  22,335.9 ns |   3,801.47 ns |   208.37 ns |   120.30 ns |  22,103.6 ns |  22,506.3 ns |    44,770.9 |      - |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 214,208.1 ns |   3,247.91 ns |   178.03 ns |   102.79 ns | 214,035.0 ns | 214,390.7 ns |     4,668.4 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 227,378.5 ns |  15,718.14 ns |   861.56 ns |   497.42 ns | 226,830.9 ns | 228,371.6 ns |     4,398.0 |      - |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 232,950.2 ns | 182,341.98 ns | 9,994.78 ns | 5,770.49 ns | 226,569.7 ns | 244,468.9 ns |     4,292.8 |      - |     128 B |
