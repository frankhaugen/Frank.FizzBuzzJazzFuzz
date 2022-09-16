using Frank.FizzBuzzJazzFuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.Rules;

/// <summary>
/// A set of rules that use the standard FizzBuzz rules
/// </summary>
public class FizzBuzzRules : RulesBase
{
    public FizzBuzzRules()
    {
        base.AddRule(new Rule(3, "Fizz"));
        base.AddRule(new Rule(5, "Buzz"));
    }
}