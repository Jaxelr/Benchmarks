# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr       | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     140.2 ns |      16.00 ns |      0.88 ns |      0.51 ns |     139.6 ns |     141.2 ns | 7,130,170.9 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     256.7 ns |      80.71 ns |      4.42 ns |      2.55 ns |     251.6 ns |     259.5 ns | 3,895,663.4 | 0.0200 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,885.6 ns |     817.10 ns |     44.79 ns |     25.86 ns |   1,834.0 ns |   1,914.4 ns |   530,324.7 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   2,112.0 ns |     636.44 ns |     34.89 ns |     20.14 ns |   2,086.6 ns |   2,151.8 ns |   473,491.5 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,174.2 ns |   1,232.03 ns |     67.53 ns |     38.99 ns |   2,100.3 ns |   2,232.8 ns |   459,940.0 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,204.4 ns |   1,301.31 ns |     71.33 ns |     41.18 ns |   2,124.7 ns |   2,262.2 ns |   453,628.9 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   2,341.0 ns |   1,083.66 ns |     59.40 ns |     34.29 ns |   2,286.8 ns |   2,404.5 ns |   427,163.0 | 0.0381 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  18,219.4 ns |   5,316.93 ns |    291.44 ns |    168.26 ns |  17,883.0 ns |  18,393.8 ns |    54,886.5 |      - |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  20,940.4 ns |  11,871.66 ns |    650.73 ns |    375.70 ns |  20,324.9 ns |  21,621.4 ns |    47,754.5 |      - |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  21,145.1 ns |   3,939.04 ns |    215.91 ns |    124.66 ns |  20,974.2 ns |  21,387.8 ns |    47,292.2 |      - |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  21,620.5 ns |  11,583.09 ns |    634.91 ns |    366.56 ns |  21,015.3 ns |  22,281.4 ns |    46,252.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  22,542.3 ns |   2,406.41 ns |    131.90 ns |     76.15 ns |  22,390.0 ns |  22,619.8 ns |    44,361.0 | 0.0305 |     248 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 211,547.6 ns |  38,798.94 ns |  2,126.70 ns |  1,227.85 ns | 209,203.4 ns | 213,353.3 ns |     4,727.1 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 231,270.9 ns | 105,876.83 ns |  5,803.47 ns |  3,350.63 ns | 226,874.9 ns | 237,849.2 ns |     4,323.9 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 690,345.9 ns | 329,042.85 ns | 18,035.95 ns | 10,413.06 ns | 678,670.4 ns | 711,118.8 ns |     1,448.5 |      - |     128 B |
