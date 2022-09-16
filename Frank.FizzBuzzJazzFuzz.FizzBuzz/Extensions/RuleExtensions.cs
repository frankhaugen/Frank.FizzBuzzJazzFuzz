using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;

public static class RuleExtensions
{
    public static string RunRule(this Rule rule, uint value) => value % rule.Divisor == 0 ? rule.Text : string.Empty;
}