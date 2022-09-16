namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

public interface IRuleSet
{
    IRuleSet AddRule(Rule rule);
    IRuleSet RemoveRule(Rule rule);
    IRuleSet FlushRules();
    string RunRules(uint value);
}