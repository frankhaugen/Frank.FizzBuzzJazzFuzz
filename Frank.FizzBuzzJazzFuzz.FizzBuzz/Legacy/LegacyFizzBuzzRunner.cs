namespace Frank.FizzBuzzJazzFuzz.FizzBuzz.Legacy;

/// <summary>
/// OBSOLETE - Only kept for posterity's sake
/// </summary>
public class LegacyFizzBuzzRunner
{
    /// <summary>
    /// Runs the familiar FizzBuzz-Scenario from 1 up to max iteration-count
    /// </summary>
    /// <param name="maxIterations"></param>
    /// <returns>A list of strings for output</returns>
    public List<string> Run(uint maxIterations)
    {
        var output = new List<string>();

        for (var i = 1; i <= maxIterations; i++)
        {
            output.Add(FizzBuzz(i));
        }

        return output;
    }

    private static string FizzBuzz(int input)
    {
        if (input % 3 == 0 && input % 5 == 0) return "FizzBuzz";
        else if (input % 3 == 0) return "Fizz";
        else if (input % 5 == 0) return "Buzz";
        else return input.ToString();
    }
}