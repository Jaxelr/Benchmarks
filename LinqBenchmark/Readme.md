# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)nt32] [52] | 100   |     183.2 ns |       4.22 ns |     0.23 ns |     0.13 ns |     182.9 ns |     183.4 ns | 5,458,619.4 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 100   |     183.6 ns |      17.87 ns |     0.98 ns |     0.57 ns |     182.5 ns |     184.5 ns | 5,446,230.0 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   1,853.3 ns |      45.77 ns |     2.51 ns |     1.45 ns |   1,850.4 ns |   1,854.8 ns |   539,566.7 | 0.0153 |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   1,858.1 ns |      62.60 ns |     3.43 ns |     1.98 ns |   1,854.2 ns |   1,860.6 ns |   538,192.6 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   1,858.1 ns |      32.70 ns |     1.79 ns |     1.03 ns |   1,856.3 ns |   1,859.9 ns |   538,179.2 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   1,858.3 ns |      41.39 ns |     2.27 ns |     1.31 ns |   1,855.8 ns |   1,860.2 ns |   538,128.0 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   1,868.6 ns |      51.44 ns |     2.82 ns |     1.63 ns |   1,865.4 ns |   1,870.8 ns |   535,152.9 | 0.0591 |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  18,230.7 ns |     712.65 ns |    39.06 ns |    22.55 ns |  18,188.5 ns |  18,265.5 ns |    54,852.6 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  18,258.4 ns |   1,167.48 ns |    63.99 ns |    36.95 ns |  18,217.1 ns |  18,332.1 ns |    54,769.3 | 0.0305 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  18,653.9 ns |     103.52 ns |     5.67 ns |     3.28 ns |  18,649.0 ns |  18,660.1 ns |    53,608.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  18,668.2 ns |   5,483.58 ns |   300.57 ns |   173.54 ns |  18,423.2 ns |  19,003.6 ns |    53,567.0 |      - |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  19,104.6 ns |  12,259.38 ns |   671.98 ns |   387.97 ns |  18,518.5 ns |  19,838.0 ns |    52,343.3 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 182,577.8 ns |   2,097.99 ns |   115.00 ns |    66.39 ns | 182,445.8 ns | 182,656.4 ns |     5,477.1 |      - |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 183,541.1 ns |  13,010.01 ns |   713.12 ns |   411.72 ns | 182,722.2 ns | 184,025.5 ns |     5,448.4 |      - |      64 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 192,131.5 ns | 143,057.99 ns | 7,841.49 ns | 4,527.29 ns | 186,559.6 ns | 201,098.4 ns |     5,204.8 |      - |     131 B |
