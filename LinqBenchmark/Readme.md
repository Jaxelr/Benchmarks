# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     134.1 ns |      59.92 ns |     3.28 ns |     1.90 ns |     130.9 ns |     137.4 ns | 7,456,844.7 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     141.8 ns |     180.30 ns |     9.88 ns |     5.71 ns |     134.8 ns |     153.1 ns | 7,053,121.5 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     906.5 ns |     682.96 ns |    37.44 ns |    21.61 ns |     874.3 ns |     947.6 ns | 1,103,091.0 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,036.1 ns |     100.34 ns |     5.50 ns |     3.18 ns |   1,029.8 ns |   1,039.5 ns |   965,114.7 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,053.3 ns |     224.38 ns |    12.30 ns |     7.10 ns |   1,043.8 ns |   1,067.2 ns |   949,442.1 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,066.0 ns |     526.45 ns |    28.86 ns |    16.66 ns |   1,039.2 ns |   1,096.5 ns |   938,101.3 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,075.0 ns |      41.78 ns |     2.29 ns |     1.32 ns |   1,072.7 ns |   1,077.3 ns |   930,225.0 | 0.0381 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   7,923.5 ns |   2,989.04 ns |   163.84 ns |    94.59 ns |   7,762.5 ns |   8,090.0 ns |   126,206.3 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,020.1 ns |     143.51 ns |     7.87 ns |     4.54 ns |  10,011.3 ns |  10,026.6 ns |    99,799.5 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  10,091.7 ns |   1,147.19 ns |    62.88 ns |    36.30 ns |  10,036.4 ns |  10,160.1 ns |    99,091.4 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,108.7 ns |   1,653.96 ns |    90.66 ns |    52.34 ns |  10,004.4 ns |  10,168.3 ns |    98,924.6 | 0.0305 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,128.5 ns |     409.03 ns |    22.42 ns |    12.94 ns |  10,102.6 ns |  10,141.8 ns |    98,731.5 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 104,275.5 ns | 109,889.00 ns | 6,023.39 ns | 3,477.60 ns |  99,810.1 ns | 111,126.3 ns |     9,590.0 |      - |     248 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 108,548.8 ns | 140,332.48 ns | 7,692.10 ns | 4,441.03 ns | 100,523.0 ns | 115,856.8 ns |     9,212.4 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 419,824.6 ns |  58,372.23 ns | 3,199.58 ns | 1,847.28 ns | 416,242.5 ns | 422,399.2 ns |     2,381.9 |      - |     128 B |
