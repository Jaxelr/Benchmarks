# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     216.2 ns |      11.93 ns |     0.65 ns |     0.38 ns |     215.7 ns |     217.0 ns | 4,624,926.8 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     242.7 ns |     204.53 ns |    11.21 ns |     6.47 ns |     235.2 ns |     255.6 ns | 4,119,569.8 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,172.4 ns |      51.44 ns |     2.82 ns |     1.63 ns |   2,169.1 ns |   2,174.1 ns |   460,322.8 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,178.2 ns |      91.57 ns |     5.02 ns |     2.90 ns |   2,172.8 ns |   2,182.8 ns |   459,087.2 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,187.7 ns |     125.78 ns |     6.89 ns |     3.98 ns |   2,182.5 ns |   2,195.5 ns |   457,091.0 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,277.7 ns |   1,479.66 ns |    81.11 ns |    46.83 ns |   2,185.3 ns |   2,337.1 ns |   439,043.9 | 0.0572 |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,419.7 ns |     907.49 ns |    49.74 ns |    28.72 ns |   2,387.5 ns |   2,477.0 ns |   413,280.2 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  21,430.3 ns |     692.14 ns |    37.94 ns |    21.90 ns |  21,386.6 ns |  21,455.1 ns |    46,662.9 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  21,477.7 ns |   1,041.49 ns |    57.09 ns |    32.96 ns |  21,428.5 ns |  21,540.3 ns |    46,559.9 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  21,530.9 ns |   1,546.43 ns |    84.77 ns |    48.94 ns |  21,446.7 ns |  21,616.2 ns |    46,445.0 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  21,851.1 ns |   8,196.17 ns |   449.26 ns |   259.38 ns |  21,544.9 ns |  22,366.9 ns |    45,764.2 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  21,901.4 ns |      32.87 ns |     1.80 ns |     1.04 ns |  21,899.4 ns |  21,902.9 ns |    45,659.1 | 0.0305 |     128 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 214,171.1 ns |  10,102.50 ns |   553.75 ns |   319.71 ns | 213,536.3 ns | 214,555.2 ns |     4,669.2 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 218,892.8 ns | 156,204.52 ns | 8,562.10 ns | 4,943.33 ns | 213,697.9 ns | 228,775.1 ns |     4,568.4 |      - |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 219,130.3 ns |  51,438.40 ns | 2,819.51 ns | 1,627.85 ns | 216,119.2 ns | 221,708.1 ns |     4,563.5 |      - |     128 B |
