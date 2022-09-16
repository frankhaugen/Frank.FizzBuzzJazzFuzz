using System.Text;

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

public abstract class RulesBase : IRules
{
    private readonly List<Rule> _rules = new();

    public IRules AddRule(Rule rule)
    {
        _rules.Add(rule);
        return this;
    }

    public IRules RemoveRule(Rule rule)
    {
        _rules.Remove(rule);
        return this;
    }

    public IRules FlushRules()
    {
        _rules.Clear();
        return this;
    }

    public string RunRules(uint value)
    {
        var stringBuilder = new StringBuilder();
        foreach (var rule in _rules) stringBuilder.Append(rule.RunRule(value));
        if (stringBuilder.Length == 0) stringBuilder.Append(value.ToString());
        return stringBuilder.ToString();
    }
}