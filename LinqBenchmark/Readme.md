# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     121.6 ns |     60.21 ns |     3.30 ns |     1.91 ns |     119.0 ns |     125.3 ns | 8,222,146.3 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     136.0 ns |    270.10 ns |    14.80 ns |     8.55 ns |     123.5 ns |     152.4 ns | 7,353,102.4 | 0.0203 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |     916.7 ns |     77.68 ns |     4.26 ns |     2.46 ns |     911.9 ns |     920.0 ns | 1,090,886.8 | 0.0200 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     928.3 ns |    195.88 ns |    10.74 ns |     6.20 ns |     920.8 ns |     940.6 ns | 1,077,270.4 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |     979.2 ns |  1,348.75 ns |    73.93 ns |    42.68 ns |     933.7 ns |   1,064.5 ns | 1,021,234.8 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,048.0 ns |  2,244.66 ns |   123.04 ns |    71.04 ns |     943.5 ns |   1,183.6 ns |   954,197.3 | 0.0200 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,165.5 ns |  1,185.79 ns |    65.00 ns |    37.53 ns |   1,123.8 ns |   1,240.4 ns |   858,022.8 | 0.0401 |     256 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |   8,887.1 ns |  1,700.37 ns |    93.20 ns |    53.81 ns |   8,820.2 ns |   8,993.6 ns |   112,522.7 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |   8,913.8 ns |  3,636.38 ns |   199.32 ns |   115.08 ns |   8,759.6 ns |   9,138.9 ns |   112,185.5 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |   8,928.1 ns |  1,239.23 ns |    67.93 ns |    39.22 ns |   8,857.5 ns |   8,993.0 ns |   112,005.5 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   9,101.2 ns |  4,174.32 ns |   228.81 ns |   132.10 ns |   8,889.3 ns |   9,343.8 ns |   109,875.7 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,119.5 ns |    384.85 ns |    21.09 ns |    12.18 ns |  10,095.2 ns |  10,132.1 ns |    98,818.8 | 0.0305 |     256 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  88,114.4 ns | 18,187.93 ns |   996.94 ns |   575.58 ns |  86,970.4 ns |  88,797.2 ns |    11,348.9 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 100,430.2 ns | 31,675.41 ns | 1,736.24 ns | 1,002.42 ns |  99,101.1 ns | 102,394.6 ns |     9,957.2 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 408,991.2 ns | 20,210.84 ns | 1,107.82 ns |   639.60 ns | 407,846.4 ns | 410,058.0 ns |     2,445.0 |      - |     128 B |
