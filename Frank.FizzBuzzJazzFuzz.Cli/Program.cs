using System.Diagnostics;

using Frank.FizzBuzzJazzFuzz.FizzBuzz;

var stopwatch = Stopwatch.StartNew();
var fizzbuzzRunner = new FizzBuzzRunner();
var result = fizzbuzzRunner.Run(100_000_000);

Console.WriteLine($"{result.Count.ToString("N")} Iterations, ran for {stopwatch.Elapsed.ToString("g")} seconds and uses {(GC.GetGCMemoryInfo().TotalCommittedBytes / 1024 / 1024).ToString("##,### MB")} RAM");
stopwatch.Stop();
Console.ReadLine();
stopwatch.Start();
result.ForEach(Console.WriteLine);

Console.WriteLine($"Total time spent: {stopwatch.Elapsed:g}");
Console.WriteLine($"Hit RETURN to close...");

Console.ReadLine();