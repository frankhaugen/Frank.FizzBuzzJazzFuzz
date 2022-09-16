using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;

public static class RuleSetExtensions
{
    public static List<string> RunRules(this IRuleSet ruleSet, UintRange range) => new RuleSetRunner(ruleSet).Run(range);
}