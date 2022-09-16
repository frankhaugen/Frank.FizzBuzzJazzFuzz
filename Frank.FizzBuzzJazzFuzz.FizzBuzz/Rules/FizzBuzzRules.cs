using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

public class FizzBuzzRules : RulesBase
{
    public FizzBuzzRules()
    {
        base.AddRule(new Rule(3, "Fizz"));
        base.AddRule(new Rule(5, "Buzz"));
    }
}