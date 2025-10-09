# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6584)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.9 (9.0.9, 9.0.925.41916), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     231.6 ns |     220.7 ns |    12.10 ns |     6.99 ns |     217.8 ns |     240.3 ns | 4,317,994.7 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     233.3 ns |     131.2 ns |     7.19 ns |     4.15 ns |     226.1 ns |     240.5 ns | 4,287,164.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,017.0 ns |   1,799.9 ns |    98.66 ns |    56.96 ns |   1,914.4 ns |   2,111.2 ns |   495,785.1 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,034.9 ns |   1,341.6 ns |    73.54 ns |    42.46 ns |   1,954.5 ns |   2,098.8 ns |   491,422.1 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   2,043.4 ns |     946.7 ns |    51.89 ns |    29.96 ns |   1,998.5 ns |   2,100.2 ns |   489,384.8 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   2,064.3 ns |   1,655.0 ns |    90.72 ns |    52.38 ns |   1,975.8 ns |   2,157.0 ns |   484,435.3 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   2,145.9 ns |     717.6 ns |    39.34 ns |    22.71 ns |   2,119.4 ns |   2,191.1 ns |   466,005.1 | 0.0572 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  19,116.0 ns |   1,229.2 ns |    67.38 ns |    38.90 ns |  19,058.6 ns |  19,190.2 ns |    52,312.3 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  19,718.6 ns |  12,297.4 ns |   674.06 ns |   389.17 ns |  18,940.6 ns |  20,127.6 ns |    50,713.5 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  19,892.5 ns |  11,990.5 ns |   657.24 ns |   379.46 ns |  19,145.6 ns |  20,382.4 ns |    50,270.3 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  20,033.7 ns |  27,364.4 ns | 1,499.94 ns |   865.99 ns |  18,394.5 ns |  21,337.7 ns |    49,915.8 | 0.0305 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  20,970.0 ns |   3,454.4 ns |   189.35 ns |   109.32 ns |  20,761.2 ns |  21,130.5 ns |    47,687.2 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 184,138.7 ns |  56,012.3 ns | 3,070.23 ns | 1,772.60 ns | 181,113.8 ns | 187,252.3 ns |     5,430.7 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 197,440.2 ns |  73,171.3 ns | 4,010.76 ns | 2,315.62 ns | 192,813.8 ns | 199,935.8 ns |     5,064.8 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 457,223.0 ns | 180,493.9 ns | 9,893.48 ns | 5,712.00 ns | 448,256.6 ns | 467,836.8 ns |     2,187.1 |      - |     128 B |
