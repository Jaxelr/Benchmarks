# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)nt32] [52] | 100   |     183.2 ns |      2.01 ns |     0.11 ns |     0.06 ns |     183.1 ns |     183.3 ns | 5,458,231.8 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 100   |     185.1 ns |     39.34 ns |     2.16 ns |     1.24 ns |     183.0 ns |     187.3 ns | 5,403,098.3 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   1,854.0 ns |    127.70 ns |     7.00 ns |     4.04 ns |   1,849.4 ns |   1,862.0 ns |   539,383.4 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   1,860.7 ns |    251.83 ns |    13.80 ns |     7.97 ns |   1,851.9 ns |   1,876.6 ns |   537,427.2 | 0.0305 |     128 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   1,863.5 ns |     71.46 ns |     3.92 ns |     2.26 ns |   1,861.1 ns |   1,868.0 ns |   536,635.0 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   1,866.4 ns |     50.98 ns |     2.79 ns |     1.61 ns |   1,863.2 ns |   1,868.3 ns |   535,802.4 | 0.0591 |     248 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,089.1 ns |  1,034.99 ns |    56.73 ns |    32.75 ns |   2,037.4 ns |   2,149.8 ns |   478,668.2 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  18,474.8 ns |  3,788.66 ns |   207.67 ns |   119.90 ns |  18,239.0 ns |  18,630.4 ns |    54,127.9 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  19,325.1 ns |  2,155.76 ns |   118.16 ns |    68.22 ns |  19,188.8 ns |  19,399.0 ns |    51,746.2 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  20,453.9 ns |  4,744.73 ns |   260.07 ns |   150.15 ns |  20,165.4 ns |  20,670.2 ns |    48,890.4 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  20,476.8 ns |  8,298.94 ns |   454.89 ns |   262.63 ns |  19,957.3 ns |  20,803.8 ns |    48,835.8 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  21,793.8 ns |  5,582.69 ns |   306.01 ns |   176.67 ns |  21,448.1 ns |  22,030.0 ns |    45,884.6 | 0.0305 |     128 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 188,926.9 ns | 71,317.88 ns | 3,909.17 ns | 2,256.96 ns | 184,523.0 ns | 191,986.6 ns |     5,293.1 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 194,221.6 ns | 38,783.94 ns | 2,125.88 ns | 1,227.38 ns | 192,573.2 ns | 196,621.1 ns |     5,148.8 |      - |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 205,883.9 ns | 40,998.37 ns | 2,247.26 ns | 1,297.46 ns | 203,703.7 ns | 208,192.7 ns |     4,857.1 |      - |     128 B |
