using Frank.FizzBuzzJazzFuzz.Models;
using Frank.FizzBuzzJazzFuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz;

/// <summary>
/// An analyzer to analyze a range of integers against the rules configured
/// </summary>
public class IntegerRangeAnalyzer
{
    private readonly IRules _rules;

    public IntegerRangeAnalyzer(IRules rules) => _rules = rules;

    /// <summary>
    /// Analyze range
    /// </summary>
    /// <param name="range"></param>
    /// <returns></returns>
    public List<string> Analyze(UintRange range) => _rules.RunRules(range);

    /// <summary>
    /// Analyze a range using supplied rules
    /// </summary>
    /// <param name="rules"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static List<string> Analyze(IRules rules, UintRange range) => rules.RunRules(range);
}