namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Models.Rulesets
{
    public class FizzBuzzRules : RuleSet
    {
        public FizzBuzzRules()
        {
            base.AddRule(new Rule(3, "Fizz"));
            base.AddRule(new Rule(5, "Buzz"));
        }
    }
}