# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr    | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|----------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     213.9 ns |      1.56 ns |     0.09 ns |   0.05 ns |     213.8 ns |     214.0 ns | 4,675,003.3 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     214.5 ns |      4.44 ns |     0.24 ns |   0.14 ns |     214.3 ns |     214.7 ns | 4,661,018.5 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,147.1 ns |  1,012.64 ns |    55.51 ns |  32.05 ns |   2,083.1 ns |   2,182.0 ns |   465,742.4 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,171.5 ns |    319.60 ns |    17.52 ns |  10.11 ns |   2,159.0 ns |   2,191.6 ns |   460,502.4 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,172.2 ns |    128.54 ns |     7.05 ns |   4.07 ns |   2,164.8 ns |   2,178.8 ns |   460,367.6 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,178.3 ns |     70.42 ns |     3.86 ns |   2.23 ns |   2,175.1 ns |   2,182.6 ns |   459,076.0 | 0.0591 |     248 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,187.0 ns |    322.84 ns |    17.70 ns |  10.22 ns |   2,176.5 ns |   2,207.4 ns |   457,249.1 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  21,252.1 ns |    374.18 ns |    20.51 ns |  11.84 ns |  21,235.3 ns |  21,275.0 ns |    47,054.1 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  21,334.2 ns |    222.05 ns |    12.17 ns |   7.03 ns |  21,320.5 ns |  21,343.7 ns |    46,873.0 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  21,343.7 ns |    247.49 ns |    13.57 ns |   7.83 ns |  21,334.7 ns |  21,359.3 ns |    46,852.3 |      - |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  21,662.4 ns |  2,951.62 ns |   161.79 ns |  93.41 ns |  21,528.7 ns |  21,842.2 ns |    46,163.0 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  23,183.9 ns | 24,070.24 ns | 1,319.37 ns | 761.74 ns |  21,808.5 ns |  24,439.0 ns |    43,133.4 | 0.0305 |     128 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 212,338.5 ns |  1,887.58 ns |   103.46 ns |  59.74 ns | 212,219.6 ns | 212,408.0 ns |     4,709.5 |      - |     128 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 212,953.0 ns |  1,074.22 ns |    58.88 ns |  34.00 ns | 212,886.0 ns | 212,996.6 ns |     4,695.9 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 213,280.7 ns |  1,991.63 ns |   109.17 ns |  63.03 ns | 213,159.4 ns | 213,371.0 ns |     4,688.7 |      - |     248 B |
