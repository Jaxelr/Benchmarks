# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.300
  [Host]   : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev    | StdErr    | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|----------:|----------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     126.4 ns |     26.94 ns |   1.48 ns |   0.85 ns |     124.8 ns |     127.8 ns | 7,913,372.5 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     137.9 ns |     16.04 ns |   0.88 ns |   0.51 ns |     137.0 ns |     138.8 ns | 7,253,199.0 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     814.7 ns |     61.08 ns |   3.35 ns |   1.93 ns |     811.2 ns |     817.8 ns | 1,227,440.0 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,037.5 ns |     62.18 ns |   3.41 ns |   1.97 ns |   1,034.0 ns |   1,040.8 ns |   963,835.7 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,037.6 ns |     92.93 ns |   5.09 ns |   2.94 ns |   1,031.9 ns |   1,041.8 ns |   963,795.9 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,092.2 ns |  1,064.58 ns |  58.35 ns |  33.69 ns |   1,053.7 ns |   1,159.3 ns |   915,606.1 | 0.0381 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,310.1 ns |  4,473.92 ns | 245.23 ns | 141.58 ns |   1,147.0 ns |   1,592.1 ns |   763,292.1 | 0.0191 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   7,835.7 ns |    957.64 ns |  52.49 ns |  30.31 ns |   7,794.8 ns |   7,894.9 ns |   127,620.6 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |   9,974.7 ns |    328.80 ns |  18.02 ns |  10.41 ns |   9,960.9 ns |   9,995.1 ns |   100,253.9 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,004.6 ns |  1,147.21 ns |  62.88 ns |  36.31 ns |   9,951.8 ns |  10,074.2 ns |    99,953.8 | 0.0305 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,027.6 ns |  1,424.49 ns |  78.08 ns |  45.08 ns |   9,974.2 ns |  10,117.2 ns |    99,724.8 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,345.3 ns |  5,891.23 ns | 322.92 ns | 186.44 ns |  10,046.7 ns |  10,688.0 ns |    96,662.0 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  99,280.2 ns |  7,976.31 ns | 437.21 ns | 252.42 ns |  98,946.9 ns |  99,775.3 ns |    10,072.5 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 |  99,317.0 ns |  7,394.15 ns | 405.30 ns | 234.00 ns |  98,864.3 ns |  99,646.3 ns |    10,068.8 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 388,869.5 ns | 11,327.89 ns | 620.92 ns | 358.49 ns | 388,326.8 ns | 389,546.6 ns |     2,571.6 |      - |     128 B |
