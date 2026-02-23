# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)nt32] [52] | 100   |     187.4 ns |     26.72 ns |     1.46 ns |     0.85 ns |     186.1 ns |     189.0 ns | 5,335,417.4 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 100   |     215.3 ns |      3.53 ns |     0.19 ns |     0.11 ns |     215.1 ns |     215.5 ns | 4,643,612.7 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,096.1 ns |  2,517.74 ns |   138.01 ns |    79.68 ns |   1,936.7 ns |   2,177.3 ns |   477,078.7 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,133.6 ns |  1,250.74 ns |    68.56 ns |    39.58 ns |   2,054.4 ns |   2,175.4 ns |   468,699.3 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,179.4 ns |     43.94 ns |     2.41 ns |     1.39 ns |   2,177.5 ns |   2,182.1 ns |   458,837.8 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,180.2 ns |     42.28 ns |     2.32 ns |     1.34 ns |   2,177.7 ns |   2,182.2 ns |   458,671.0 | 0.0591 |     248 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,284.4 ns |  1,665.73 ns |    91.30 ns |    52.71 ns |   2,190.0 ns |   2,372.3 ns |   437,755.7 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  21,326.1 ns |    194.89 ns |    10.68 ns |     6.17 ns |  21,313.8 ns |  21,333.4 ns |    46,891.0 | 0.0305 |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  21,377.0 ns |     98.88 ns |     5.42 ns |     3.13 ns |  21,371.1 ns |  21,381.7 ns |    46,779.2 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  21,417.4 ns |    231.80 ns |    12.71 ns |     7.34 ns |  21,405.3 ns |  21,430.6 ns |    46,691.0 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  21,705.7 ns |  5,855.75 ns |   320.97 ns |   185.31 ns |  21,373.9 ns |  22,014.6 ns |    46,070.8 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  21,878.3 ns |    388.84 ns |    21.31 ns |    12.31 ns |  21,855.4 ns |  21,897.6 ns |    45,707.5 | 0.0305 |     128 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 213,422.4 ns |  5,310.20 ns |   291.07 ns |   168.05 ns | 213,231.3 ns | 213,757.4 ns |     4,685.5 |      - |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 213,663.1 ns |  2,462.99 ns |   135.00 ns |    77.95 ns | 213,572.9 ns | 213,818.3 ns |     4,680.3 |      - |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 216,608.0 ns | 92,443.95 ns | 5,067.17 ns | 2,925.53 ns | 213,670.4 ns | 222,459.1 ns |     4,616.6 |      - |      64 B |
