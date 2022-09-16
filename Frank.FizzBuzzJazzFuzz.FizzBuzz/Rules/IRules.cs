using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

public interface IRules
{
    IRules AddRule(Rule rule);
    IRules RemoveRule(Rule rule);
    IRules FlushRules();
    string RunRules(uint value);
    List<string> RunRules(UintRange range);
}