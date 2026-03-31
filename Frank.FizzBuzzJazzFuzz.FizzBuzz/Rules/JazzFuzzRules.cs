using Frank.FizzBuzzJazzFuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.Rules;

public class JazzFuzzRules : RulesBase
{
    public JazzFuzzRules()
    {
        AddRule(new Rule(9, "Jazz"));
        AddRule(new Rule(4, "Fuzz"));
    }
}