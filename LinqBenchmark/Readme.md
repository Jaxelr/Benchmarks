# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     186.2 ns |      40.67 ns |      2.23 ns |     1.29 ns |     183.6 ns |     187.6 ns | 5,370,620.4 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     223.6 ns |      42.47 ns |      2.33 ns |     1.34 ns |     221.1 ns |     225.6 ns | 4,471,421.9 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,144.8 ns |   1,120.22 ns |     61.40 ns |    35.45 ns |   2,075.1 ns |   2,190.7 ns |   466,240.3 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,171.9 ns |      49.67 ns |      2.72 ns |     1.57 ns |   2,169.2 ns |   2,174.6 ns |   460,417.6 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,191.8 ns |     151.42 ns |      8.30 ns |     4.79 ns |   2,183.2 ns |   2,199.7 ns |   456,236.2 | 0.0572 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,329.1 ns |   4,106.53 ns |    225.09 ns |   129.96 ns |   2,178.3 ns |   2,587.8 ns |   429,356.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,443.1 ns |   4,440.81 ns |    243.42 ns |   140.54 ns |   2,169.8 ns |   2,636.6 ns |   409,310.9 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  18,442.9 ns |   4,658.88 ns |    255.37 ns |   147.44 ns |  18,276.5 ns |  18,736.9 ns |    54,221.4 |      - |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  18,527.0 ns |   7,205.33 ns |    394.95 ns |   228.02 ns |  18,233.7 ns |  18,976.1 ns |    53,975.4 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  18,848.6 ns |   2,969.25 ns |    162.75 ns |    93.97 ns |  18,733.5 ns |  19,034.8 ns |    53,054.3 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  18,888.7 ns |   2,654.65 ns |    145.51 ns |    84.01 ns |  18,750.1 ns |  19,040.3 ns |    52,941.6 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  19,654.5 ns |  24,645.33 ns |  1,350.89 ns |   779.94 ns |  18,784.1 ns |  21,210.8 ns |    50,878.8 |      - |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 191,243.4 ns |  49,374.68 ns |  2,706.39 ns | 1,562.54 ns | 189,160.2 ns | 194,302.4 ns |     5,228.9 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 202,720.0 ns | 203,157.08 ns | 11,135.73 ns | 6,429.21 ns | 190,028.4 ns | 210,853.7 ns |     4,932.9 |      - |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 211,434.6 ns |  16,663.31 ns |    913.37 ns |   527.34 ns | 210,468.1 ns | 212,283.4 ns |     4,729.6 |      - |     128 B |
