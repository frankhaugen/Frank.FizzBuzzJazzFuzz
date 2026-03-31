using Frank.FizzBuzzJazzFuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.Extensions;

public static class RuleExtensions
{
    public static string RunRule(this Rule rule, uint value) => value % rule.Divisor == 0 ? rule.Text : string.Empty;

    // public static string RunRuleV2(this RuleV2 rule, uint value) => rule.Calculation.Invoke(value) ? rule.Text : string.Empty;
}