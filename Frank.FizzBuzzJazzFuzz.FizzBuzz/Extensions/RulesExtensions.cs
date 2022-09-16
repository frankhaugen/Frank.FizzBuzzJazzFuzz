using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;

public static class RulesExtensions
{
    public static List<string> RunRules(this IRules source, UintRange range) => new IntegerRangeAnalyzer(source).Run(range);
}