# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.200
  [Host]   : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|       Method |          array | value |       Mean |      Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------- |--------------- |------ |-----------:|-----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
| AppendCopyTo | System.Int32[] |     4 |   609.4 ns |   169.7 ns |   9.30 ns |  0.56 |    0.01 |  2.5702 |     - |     - |   3.94 KB |
| AppendConcat | System.Int32[] |     4 |   906.9 ns |   267.7 ns |  14.68 ns |  0.83 |    0.02 |  2.6588 |     - |     - |   4.08 KB |
|       Append | System.Int32[] |     4 | 1,093.4 ns |   184.9 ns |  10.14 ns |  1.00 |    0.00 |  2.5692 |     - |     - |   3.94 KB |
| AppendToList | System.Int32[] |     4 | 2,538.6 ns | 2,256.5 ns | 123.69 ns |  2.32 |    0.12 | 10.2386 |     - |     - |  15.73 KB |
|              |                |       |            |            |           |       |         |         |       |       |           |
| AppendCopyTo | System.Int32[] |   101 |   610.5 ns |   125.2 ns |   6.86 ns |  0.56 |    0.02 |  2.5702 |     - |     - |   3.94 KB |
| AppendConcat | System.Int32[] |   101 |   891.7 ns |   129.3 ns |   7.09 ns |  0.81 |    0.03 |  2.6588 |     - |     - |   4.08 KB |
|       Append | System.Int32[] |   101 | 1,097.3 ns |   889.3 ns |  48.75 ns |  1.00 |    0.00 |  2.5692 |     - |     - |   3.94 KB |
| AppendToList | System.Int32[] |   101 | 2,615.3 ns |   481.9 ns |  26.41 ns |  2.39 |    0.11 | 10.2386 |     - |     - |  15.73 KB |
