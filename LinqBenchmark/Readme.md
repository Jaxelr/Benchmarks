# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)nt32] [52] | 100   |     185.9 ns |       1.19 ns |      0.07 ns |     0.04 ns |     185.8 ns |     185.9 ns | 5,380,652.5 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 100   |     192.8 ns |     234.19 ns |     12.84 ns |     7.41 ns |     182.9 ns |     207.3 ns | 5,186,328.5 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   1,940.2 ns |   2,087.00 ns |    114.40 ns |    66.05 ns |   1,859.2 ns |   2,071.1 ns |   515,403.9 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   1,975.8 ns |   2,699.09 ns |    147.95 ns |    85.42 ns |   1,863.1 ns |   2,143.4 ns |   506,122.7 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,188.1 ns |     276.80 ns |     15.17 ns |     8.76 ns |   2,176.6 ns |   2,205.3 ns |   457,009.0 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,188.4 ns |     217.56 ns |     11.93 ns |     6.89 ns |   2,174.7 ns |   2,196.7 ns |   456,963.4 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,207.7 ns |     313.80 ns |     17.20 ns |     9.93 ns |   2,187.8 ns |   2,217.7 ns |   452,967.2 | 0.0572 |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  21,160.2 ns |   2,644.65 ns |    144.96 ns |    83.69 ns |  21,023.0 ns |  21,311.8 ns |    47,258.6 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  21,162.8 ns |   3,435.87 ns |    188.33 ns |   108.73 ns |  20,980.1 ns |  21,356.3 ns |    47,252.8 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  21,389.2 ns |   8,782.76 ns |    481.41 ns |   277.94 ns |  21,060.6 ns |  21,941.8 ns |    46,752.6 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  23,593.4 ns |  14,618.93 ns |    801.31 ns |   462.64 ns |  22,920.8 ns |  24,480.0 ns |    42,384.7 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  24,224.3 ns |  21,446.08 ns |  1,175.53 ns |   678.69 ns |  23,422.7 ns |  25,573.8 ns |    41,280.8 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 237,887.4 ns | 140,666.51 ns |  7,710.41 ns | 4,451.60 ns | 232,365.6 ns | 246,696.6 ns |     4,203.7 |      - |     128 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 238,792.6 ns | 152,517.61 ns |  8,360.01 ns | 4,826.65 ns | 231,200.3 ns | 247,751.8 ns |     4,187.7 |      - |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 242,829.6 ns | 203,216.58 ns | 11,138.99 ns | 6,431.10 ns | 233,465.5 ns | 255,147.9 ns |     4,118.1 |      - |      64 B |
