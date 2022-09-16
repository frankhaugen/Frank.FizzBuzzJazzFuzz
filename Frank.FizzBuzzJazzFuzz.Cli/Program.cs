//var result = typeof(IRules).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(RulesBase))).Select(x => x.Name);

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

var rules = new FizzBuzzRules();
var result = rules.RunRules(new UintRange(1, 100));

Console.WriteLine(string.Join("\n", result));

Console.ReadLine();