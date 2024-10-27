# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr    | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|----------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     129.9 ns |     26.64 ns |     1.46 ns |   0.84 ns |     129.0 ns |     131.6 ns | 7,697,750.3 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     135.0 ns |    245.77 ns |    13.47 ns |   7.78 ns |     123.6 ns |     149.8 ns | 7,407,714.1 | 0.0203 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |     932.3 ns |    593.62 ns |    32.54 ns |  18.79 ns |     913.0 ns |     969.9 ns | 1,072,634.5 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |     979.5 ns |    466.45 ns |    25.57 ns |  14.76 ns |     951.2 ns |   1,001.0 ns | 1,020,897.9 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,054.1 ns |  1,083.89 ns |    59.41 ns |  34.30 ns |     997.5 ns |   1,116.0 ns |   948,717.9 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,213.9 ns |    781.25 ns |    42.82 ns |  24.72 ns |   1,166.2 ns |   1,249.1 ns |   823,807.0 | 0.0401 |     256 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,225.6 ns |  6,140.14 ns |   336.56 ns | 194.31 ns |     948.7 ns |   1,600.2 ns |   815,905.6 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |   8,999.3 ns |  2,107.93 ns |   115.54 ns |  66.71 ns |   8,868.3 ns |   9,086.8 ns |   111,119.4 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |   9,097.1 ns |  4,134.71 ns |   226.64 ns | 130.85 ns |   8,851.7 ns |   9,298.5 ns |   109,924.8 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  10,013.2 ns | 17,289.71 ns |   947.71 ns | 547.16 ns |   9,282.7 ns |  11,084.1 ns |    99,867.8 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,461.2 ns | 10,735.05 ns |   588.42 ns | 339.73 ns |  10,107.3 ns |  11,140.4 ns |    95,591.7 | 0.0305 |     256 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  18,775.7 ns | 20,745.77 ns | 1,137.15 ns | 656.53 ns |  17,469.0 ns |  19,540.5 ns |    53,260.2 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  87,397.1 ns |  9,511.79 ns |   521.37 ns | 301.02 ns |  86,884.1 ns |  87,926.5 ns |    11,442.0 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 |  99,756.1 ns |  8,312.14 ns |   455.62 ns | 263.05 ns |  99,249.8 ns | 100,133.0 ns |    10,024.4 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 387,210.5 ns |  8,862.26 ns |   485.77 ns | 280.46 ns | 386,655.8 ns | 387,559.9 ns |     2,582.6 |      - |     128 B |
