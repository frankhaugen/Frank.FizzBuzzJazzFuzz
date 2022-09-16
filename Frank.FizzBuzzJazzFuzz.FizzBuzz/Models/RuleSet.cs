using System.Text;

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

public abstract class RuleSet : IRuleSet
{
    private readonly List<Rule> _rules = new();

    public IRuleSet AddRule(Rule rule)
    {
        _rules.Add(rule);
        return this;
    }

    public IRuleSet RemoveRule(Rule rule)
    {
        _rules.Remove(rule);
        return this;
    }

    public IRuleSet FlushRules()
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