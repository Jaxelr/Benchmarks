# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 4.7185 ns | 1.9328 ns | 0.1059 ns | 0.0612 ns | 4.6262 ns | 4.8342 ns |    211,931,484.5 | 0.0038 |      24 B |
| Open_AddToArray   | 5.5503 ns | 6.4036 ns | 0.3510 ns | 0.2027 ns | 5.2774 ns | 5.9462 ns |    180,171,905.9 | 0.0038 |      24 B |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.2187 ns | 0.2015 ns | 0.0110 ns | 0.0064 ns | 0.2074 ns | 0.2295 ns |  4,572,369,931.5 |      - |         - |
| Open_Casting      | 1.5853 ns | 0.5562 ns | 0.0305 ns | 0.0176 ns | 1.5612 ns | 1.6195 ns |    630,812,225.6 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_IntMethod  | 0.0180 ns | 0.1069 ns | 0.0059 ns | 0.0034 ns | 0.0146 ns | 0.0248 ns | 55,504,493,326.5 |      - |         - |
| Open_IntMethod    | 0.2454 ns | 0.1149 ns | 0.0063 ns | 0.0036 ns | 0.2381 ns | 0.2492 ns |  4,075,707,286.3 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Open_ToString     | 5.5828 ns | 2.1451 ns | 0.1176 ns | 0.0679 ns | 5.4610 ns | 5.6956 ns |    179,121,348.3 |      - |         - |
| Sealed_ToString   | 5.7598 ns | 0.6607 ns | 0.0362 ns | 0.0209 ns | 5.7195 ns | 5.7897 ns |    173,616,481.4 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Open_VoidMethod   | 0.0120 ns | 0.1254 ns | 0.0069 ns | 0.0040 ns | 0.0043 ns | 0.0175 ns | 83,070,517,884.3 |      - |         - |
| Sealed_VoidMethod | 0.0424 ns | 1.0522 ns | 0.0577 ns | 0.0333 ns | 0.0000 ns | 0.1081 ns | 23,563,677,988.0 |      - |         - |
