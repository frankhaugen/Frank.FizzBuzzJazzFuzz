using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

/// <summary>
/// A read-only set of rules that use the standard FizzBuzz rules
/// </summary>
public class FizzBuzzRules : RulesBase
{
    public FizzBuzzRules()
    {
        base.AddRule(new Rule(3, "Fizz"));
        base.AddRule(new Rule(5, "Buzz"));
    }

    /// <summary>
    /// Does nothing
    /// </summary>
    /// <param name="rule"></param>
    /// <returns></returns>
    new IRules AddRule(Rule rule) => this;

    /// <summary>
    /// Does nothing
    /// </summary>
    /// <param name="rule"></param>
    /// <returns></returns>
    new IRules RemoveRule(Rule rule) => this;

    /// <summary>
    /// Does nothing
    /// </summary>
    /// <returns></returns>
    new IRules FlushRules() => this;
}