# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)nt32] [52] | 100   |     227.1 ns |     28.15 ns |     1.54 ns |     0.89 ns |     225.4 ns |     228.3 ns | 4,402,775.3 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 100   |     250.6 ns |     75.83 ns |     4.16 ns |     2.40 ns |     246.6 ns |     254.9 ns | 3,990,788.8 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,292.8 ns |    536.19 ns |    29.39 ns |    16.97 ns |   2,261.2 ns |   2,319.4 ns |   436,153.3 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,323.1 ns |    202.99 ns |    11.13 ns |     6.42 ns |   2,313.0 ns |   2,335.1 ns |   430,450.6 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,336.2 ns |    199.78 ns |    10.95 ns |     6.32 ns |   2,328.1 ns |   2,348.7 ns |   428,043.2 | 0.0572 |     248 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,354.2 ns |    395.87 ns |    21.70 ns |    12.53 ns |   2,332.4 ns |   2,375.7 ns |   424,764.4 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,372.7 ns |    340.84 ns |    18.68 ns |    10.79 ns |   2,359.2 ns |   2,394.0 ns |   421,462.4 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  23,002.9 ns |  5,521.22 ns |   302.64 ns |   174.73 ns |  22,756.0 ns |  23,340.5 ns |    43,472.8 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  23,236.6 ns | 28,937.23 ns | 1,586.15 ns |   915.76 ns |  22,295.0 ns |  25,067.9 ns |    43,035.6 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  23,271.9 ns |  3,223.90 ns |   176.71 ns |   102.03 ns |  23,067.8 ns |  23,374.3 ns |    42,970.3 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  25,336.8 ns | 30,543.03 ns | 1,674.17 ns |   966.58 ns |  23,457.5 ns |  26,669.0 ns |    39,468.3 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  26,338.5 ns | 17,108.88 ns |   937.80 ns |   541.44 ns |  25,403.8 ns |  27,279.4 ns |    37,967.3 | 0.0305 |     248 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 221,177.5 ns | 33,524.76 ns | 1,837.61 ns | 1,060.94 ns | 219,580.4 ns | 223,185.9 ns |     4,521.3 |      - |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 229,087.5 ns | 54,368.43 ns | 2,980.12 ns | 1,720.57 ns | 226,149.2 ns | 232,107.8 ns |     4,365.1 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 229,548.3 ns | 37,241.14 ns | 2,041.31 ns | 1,178.55 ns | 227,634.0 ns | 231,696.5 ns |     4,356.4 |      - |     128 B |
