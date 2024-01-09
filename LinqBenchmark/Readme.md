# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     120.6 ns |     37.50 ns |     2.06 ns |     1.19 ns |     118.2 ns |     121.9 ns | 8,295,162.4 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     130.4 ns |     38.40 ns |     2.10 ns |     1.22 ns |     129.2 ns |     132.9 ns | 7,666,503.6 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |     911.9 ns |    103.02 ns |     5.65 ns |     3.26 ns |     905.6 ns |     916.4 ns | 1,096,597.9 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |     919.2 ns |     70.79 ns |     3.88 ns |     2.24 ns |     916.7 ns |     923.7 ns | 1,087,880.1 | 0.0200 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     934.7 ns |    122.79 ns |     6.73 ns |     3.89 ns |     926.9 ns |     938.9 ns | 1,069,907.7 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |     955.3 ns |    297.73 ns |    16.32 ns |     9.42 ns |     942.2 ns |     973.6 ns | 1,046,791.2 | 0.0200 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,126.4 ns |    111.70 ns |     6.12 ns |     3.53 ns |   1,119.6 ns |   1,131.6 ns |   887,805.3 | 0.0401 |     256 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   8,793.2 ns |    949.39 ns |    52.04 ns |    30.04 ns |   8,739.0 ns |   8,842.8 ns |   113,724.0 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |   8,878.1 ns |  1,196.18 ns |    65.57 ns |    37.85 ns |   8,805.3 ns |   8,932.5 ns |   112,636.4 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |   8,916.2 ns |  2,345.71 ns |   128.58 ns |    74.23 ns |   8,773.7 ns |   9,023.6 ns |   112,155.3 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |   9,131.5 ns |  2,225.02 ns |   121.96 ns |    70.41 ns |   9,042.9 ns |   9,270.6 ns |   109,511.3 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,088.5 ns |  1,448.37 ns |    79.39 ns |    45.84 ns |   9,998.0 ns |  10,146.4 ns |    99,123.0 | 0.0305 |     256 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  93,161.2 ns | 34,696.14 ns | 1,901.81 ns | 1,098.01 ns |  91,437.6 ns |  95,201.5 ns |    10,734.1 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 100,361.4 ns | 11,311.23 ns |   620.01 ns |   357.96 ns |  99,700.3 ns | 100,929.8 ns |     9,964.0 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 413,544.6 ns | 20,908.45 ns | 1,146.06 ns |   661.68 ns | 412,405.7 ns | 414,697.7 ns |     2,418.1 |      - |     128 B |
