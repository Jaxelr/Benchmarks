# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1702)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |      Mean |    Error |    StdDev |    StdErr |       Min |       Max |      Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|
| ParallelForEach |  9.611 μs | 6.338 μs | 0.3474 μs | 0.2006 μs |  9.211 μs |  9.833 μs | 104,045.7 | 1.8616 | 0.0305 |  10.68 KB |
|      AsParallel | 15.211 μs | 7.172 μs | 0.3931 μs | 0.2270 μs | 14.757 μs | 15.440 μs |  65,741.7 | 1.5259 | 0.0305 |   9.16 KB |
