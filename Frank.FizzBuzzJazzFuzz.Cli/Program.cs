using Frank.FizzBuzzJazzFuzz.FizzBuzz;

var fizzbuzzRunner = new FizzBuzzRunner();
var result = fizzbuzzRunner.Run(100);

Console.WriteLine(string.Join("\n", result));