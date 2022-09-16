using Frank.FizzBuzzJazzFuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.Rules;

public interface IRules
{
    IRules AddRule(Rule rule);
    IRules RemoveRule(Rule rule);
    string RunRules(uint value);
    List<string> RunRules(UintRange range);
}