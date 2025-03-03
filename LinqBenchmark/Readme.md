# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr    | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|----------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     127.5 ns |     12.47 ns |     0.68 ns |   0.39 ns |     126.7 ns |     127.9 ns | 7,844,431.4 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     135.6 ns |     82.52 ns |     4.52 ns |   2.61 ns |     130.7 ns |     139.6 ns | 7,377,073.1 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     819.5 ns |     55.68 ns |     3.05 ns |   1.76 ns |     816.1 ns |     821.9 ns | 1,220,198.5 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,039.8 ns |    211.71 ns |    11.60 ns |   6.70 ns |   1,030.6 ns |   1,052.8 ns |   961,743.8 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,045.7 ns |    222.66 ns |    12.20 ns |   7.05 ns |   1,032.2 ns |   1,056.0 ns |   956,330.9 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,046.3 ns |     50.76 ns |     2.78 ns |   1.61 ns |   1,043.2 ns |   1,048.5 ns |   955,762.1 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,074.1 ns |    248.92 ns |    13.64 ns |   7.88 ns |   1,064.4 ns |   1,089.7 ns |   930,983.6 | 0.0381 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   7,922.1 ns |  1,034.20 ns |    56.69 ns |  32.73 ns |   7,856.9 ns |   7,960.3 ns |   126,229.8 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,110.5 ns |    205.83 ns |    11.28 ns |   6.51 ns |  10,097.7 ns |  10,118.7 ns |    98,906.8 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,206.4 ns |  4,946.91 ns |   271.16 ns | 156.55 ns |  10,016.4 ns |  10,516.9 ns |    97,977.6 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  10,219.6 ns |  4,251.85 ns |   233.06 ns | 134.56 ns |  10,062.7 ns |  10,487.4 ns |    97,851.0 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,319.5 ns |  2,298.23 ns |   125.97 ns |  72.73 ns |  10,229.1 ns |  10,463.4 ns |    96,903.8 | 0.0305 |     248 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 100,298.1 ns | 21,984.15 ns | 1,205.03 ns | 695.72 ns |  99,411.2 ns | 101,670.0 ns |     9,970.3 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 101,001.2 ns | 21,676.83 ns | 1,188.18 ns | 686.00 ns |  99,646.2 ns | 101,865.2 ns |     9,900.9 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 390,526.4 ns | 10,607.90 ns |   581.45 ns | 335.70 ns | 389,855.0 ns | 390,866.5 ns |     2,560.6 |      - |     128 B |
