# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr    | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|----------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     242.1 ns |     17.91 ns |     0.98 ns |   0.57 ns |     241.1 ns |     243.0 ns | 4,129,679.2 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     255.4 ns |    480.99 ns |    26.36 ns |  15.22 ns |     239.9 ns |     285.8 ns | 3,915,317.0 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   2,138.6 ns |     74.79 ns |     4.10 ns |   2.37 ns |   2,135.2 ns |   2,143.1 ns |   467,601.2 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,141.5 ns |     24.90 ns |     1.36 ns |   0.79 ns |   2,140.0 ns |   2,142.4 ns |   466,951.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,156.7 ns |     90.27 ns |     4.95 ns |   2.86 ns |   2,151.0 ns |   2,160.0 ns |   463,670.6 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   2,158.2 ns |     66.57 ns |     3.65 ns |   2.11 ns |   2,154.2 ns |   2,161.2 ns |   463,339.7 | 0.0572 |     248 B |
| SingleUsage | Syste(...)rator [36] | 100   |   2,204.8 ns |    402.80 ns |    22.08 ns |  12.75 ns |   2,179.3 ns |   2,218.4 ns |   453,559.6 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  21,111.1 ns |    365.68 ns |    20.04 ns |  11.57 ns |  21,095.6 ns |  21,133.7 ns |    47,368.4 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  21,112.5 ns |    362.38 ns |    19.86 ns |  11.47 ns |  21,100.7 ns |  21,135.5 ns |    47,365.2 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  21,144.9 ns |    377.39 ns |    20.69 ns |  11.94 ns |  21,121.7 ns |  21,161.4 ns |    47,292.7 | 0.0305 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  21,772.5 ns |    450.30 ns |    24.68 ns |  14.25 ns |  21,757.4 ns |  21,801.0 ns |    45,929.4 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  22,057.1 ns | 28,832.82 ns | 1,580.42 ns | 912.46 ns |  21,130.4 ns |  23,882.0 ns |    45,336.8 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 210,642.4 ns |  2,456.61 ns |   134.65 ns |  77.74 ns | 210,535.5 ns | 210,793.7 ns |     4,747.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 210,837.0 ns |  7,775.00 ns |   426.17 ns | 246.05 ns | 210,372.8 ns | 211,210.5 ns |     4,743.0 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 496,914.4 ns |  2,415.42 ns |   132.40 ns |  76.44 ns | 496,761.6 ns | 496,996.5 ns |     2,012.4 |      - |     128 B |
