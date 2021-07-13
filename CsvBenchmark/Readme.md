# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.928 (2004/?/20H1)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.202
  [Host]   : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  ShortRun : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|      Method |             examples   |         Mean |        Error |      StdDev |       Gen 0 |      Gen 1 |     Gen 2 |  Allocated |
|------------ |----------------------- |-------------:|-------------:|------------:|------------:|-----------:|----------:|-----------:|
| GenerateCsv | List<Example>(5_000)   |     84.50 ms |    233.57 ms |    12.80 ms |   6000.0000 |          - |         - |   25.49 MB |
| GenerateCsv | List<Example>(50_000)  |  7,719.48 ms | 22,996.22 ms | 1,260.50 ms | 431000.0000 |          - |         - |  2400.3 MB |
| GenerateCsv | List<Example>(100_000) | 51,689.38 ms | 55,514.93 ms | 3,042.96 ms | 447000.0000 | 15000.0000 | 1000.0000 | 9568.95 MB |