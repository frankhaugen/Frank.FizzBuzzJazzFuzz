using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.FizzBuzz;

public class IntegerRangeAnalyzer
{
    private readonly IRules _ruleSet;

    public IntegerRangeAnalyzer(IRules ruleSet)
    {
        _ruleSet = ruleSet;
    }

    public List<string> Run(UintRange range)
    {
        var output = new List<string>();

        if (range.Start < range.End)
        {
            for (var i = range.Start; i <= range.End; i++)
            {
                output.Add(_ruleSet.RunRules(i));
            }
        }
        else if (range.Start > range.End)
        {
            for (var i = range.Start; i >= range.End; i--)
            {
                output.Add(_ruleSet.RunRules(i));
            }
        }

        return output;
    }
}