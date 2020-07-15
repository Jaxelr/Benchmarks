# SQLConnectionBenchmark

I am ware that using multiple usings ads a penalty to the execution of the query, but i needed to measure how much, heres how much on my machine:

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.778 (1909/November2018Update/19H2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]   : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```

|                Method |       Mean |       Error |     StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|------------:|-----------:|---------:|------:|------:|------:|----------:|
| WithoutUsingExecution |   740.7 μs |  5,779.9 μs |   316.8 μs | 599.7 μs |     - |     - |     - |   7.46 KB |
|    WithUsingExecution | 1,259.0 μs | 19,785.3 μs | 1,084.5 μs | 705.9 μs |     - |     - |     - |   9.92 KB |
