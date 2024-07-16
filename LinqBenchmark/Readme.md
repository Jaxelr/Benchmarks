# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     201.6 ns |     278.3 ns |    15.25 ns |     8.81 ns |     189.1 ns |     218.6 ns | 4,961,513.6 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     523.9 ns |     947.6 ns |    51.94 ns |    29.99 ns |     486.7 ns |     583.2 ns | 1,908,914.6 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,259.4 ns |     119.9 ns |     6.57 ns |     3.80 ns |   1,253.5 ns |   1,266.5 ns |   794,049.1 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,585.3 ns |   1,567.1 ns |    85.90 ns |    49.59 ns |   1,533.7 ns |   1,684.5 ns |   630,784.0 | 0.0381 |     256 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,715.6 ns |  12,186.0 ns |   667.96 ns |   385.64 ns |   1,250.9 ns |   2,481.0 ns |   582,890.9 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,990.5 ns |   4,174.7 ns |   228.83 ns |   132.11 ns |   1,726.9 ns |   2,137.2 ns |   502,377.5 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,075.8 ns |  10,756.2 ns |   589.59 ns |   340.40 ns |   1,635.3 ns |   2,745.6 ns |   481,732.7 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  12,389.2 ns |   1,462.8 ns |    80.18 ns |    46.29 ns |  12,322.6 ns |  12,478.2 ns |    80,715.4 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  12,760.4 ns |   2,230.6 ns |   122.27 ns |    70.59 ns |  12,630.5 ns |  12,873.2 ns |    78,367.6 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  13,985.2 ns |   3,485.8 ns |   191.07 ns |   110.31 ns |  13,802.4 ns |  14,183.6 ns |    71,504.1 | 0.0305 |     256 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  14,399.7 ns |   6,575.2 ns |   360.41 ns |   208.08 ns |  14,032.3 ns |  14,752.7 ns |    69,445.7 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  15,192.7 ns |  40,193.3 ns | 2,203.13 ns | 1,271.98 ns |  13,167.7 ns |  17,538.8 ns |    65,821.1 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 121,775.3 ns |  34,662.6 ns | 1,899.97 ns | 1,096.95 ns | 120,363.3 ns | 123,935.4 ns |     8,211.8 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 138,141.6 ns |  29,909.8 ns | 1,639.46 ns |   946.54 ns | 136,720.4 ns | 139,935.3 ns |     7,238.9 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 547,184.2 ns | 103,077.7 ns | 5,650.04 ns | 3,262.05 ns | 540,702.8 ns | 551,070.2 ns |     1,827.5 |      - |     128 B |
