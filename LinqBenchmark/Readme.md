# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.402
  [Host]   : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.13 (10.0.13, 10.0.1326.50504), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)nt32] [52] | 100   |     231.8 ns |      62.86 ns |      3.45 ns |     1.99 ns |     228.1 ns |     234.8 ns | 4,313,816.9 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 100   |     239.6 ns |      13.14 ns |      0.72 ns |     0.42 ns |     238.9 ns |     240.3 ns | 4,172,834.2 | 0.0153 |      64 B |
| FirstUsage  | Syste(...)nt32] [52] | 1000  |   2,123.5 ns |     279.58 ns |     15.32 ns |     8.85 ns |   2,106.8 ns |   2,136.9 ns |   470,929.6 | 0.0153 |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 1000  |   2,369.3 ns |     193.38 ns |     10.60 ns |     6.12 ns |   2,357.6 ns |   2,378.3 ns |   422,072.3 | 0.0153 |      64 B |
| CountUsage  | Syste(...)nt32] [52] | 100   |   2,377.5 ns |     929.33 ns |     50.94 ns |    29.41 ns |   2,329.1 ns |   2,430.6 ns |   420,615.5 | 0.0153 |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 100   |   2,392.3 ns |   1,007.44 ns |     55.22 ns |    31.88 ns |   2,343.2 ns |   2,452.1 ns |   418,006.7 | 0.0572 |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 100   |   2,397.6 ns |     262.34 ns |     14.38 ns |     8.30 ns |   2,386.5 ns |   2,413.8 ns |   417,086.5 | 0.0305 |     128 B |
| SingleUsage | Syste(...)nt32] [52] | 1000  |  20,979.2 ns |   7,719.88 ns |    423.15 ns |   244.31 ns |  20,707.6 ns |  21,466.7 ns |    47,666.3 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)nt32] [52] | 10000 |  21,569.9 ns |   3,315.51 ns |    181.73 ns |   104.92 ns |  21,444.8 ns |  21,778.4 ns |    46,360.9 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 1000  |  22,788.6 ns |  14,147.06 ns |    775.45 ns |   447.71 ns |  22,148.6 ns |  23,650.9 ns |    43,881.6 | 0.0305 |     248 B |
| CountUsage  | Syste(...)nt32] [52] | 1000  |  23,015.0 ns |  15,466.80 ns |    847.79 ns |   489.47 ns |  22,050.3 ns |  23,641.1 ns |    43,449.9 |      - |      64 B |
| AnyUsage    | Syste(...)nt32] [52] | 10000 |  23,354.7 ns |   3,587.43 ns |    196.64 ns |   113.53 ns |  23,128.5 ns |  23,484.9 ns |    42,817.9 |      - |      64 B |
| WhereUsage  | Syste(...)nt32] [52] | 10000 | 227,508.9 ns | 112,627.11 ns |  6,173.47 ns | 3,564.26 ns | 223,763.8 ns | 234,634.3 ns |     4,395.4 |      - |     248 B |
| SingleUsage | Syste(...)nt32] [52] | 10000 | 233,814.0 ns |  50,494.22 ns |  2,767.76 ns | 1,597.97 ns | 230,662.1 ns | 235,847.6 ns |     4,276.9 |      - |     128 B |
| CountUsage  | Syste(...)nt32] [52] | 10000 | 255,172.8 ns | 264,588.19 ns | 14,502.97 ns | 8,373.29 ns | 238,585.6 ns | 265,462.5 ns |     3,918.9 |      - |      64 B |
