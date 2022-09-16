using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.FizzBuzz;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

using Xunit.Abstractions;

namespace Frank.FizzBuzzJazzFuzz.Tests.Runners;

public class RuleSetRunnerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public RuleSetRunnerTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void Run_Ascending_ExpectedBehavior()
    {
        // Arrange
        var rules = new DefaultRules()
            .AddRule(new Rule(3, "Fizz"))
            .AddRule(new Rule(5, "Buzz"));

        var ruleSetRunner = new RuleSetRunner(rules);
        var expected = File.ReadAllLines("Files/fizzbuzz.txt");
        var range = new UintRange(1, 100);

        // Act
        var result = ruleSetRunner.Run(range);

        // Assert
        _outputHelper.WriteLine(string.Join("\n", result));
        result.Should().Equal(expected);
    }

    [Fact]
    public void Run_Descending_ExpectedBehavior()
    {
        // Arrange
        var rules = new DefaultRules()
            .AddRule(new Rule(3, "Fizz"))
            .AddRule(new Rule(5, "Buzz"));

        var ruleSetRunner = new RuleSetRunner(rules);
        var expected = File.ReadAllLines("Files/fizzbuzz.txt");
        var range = new UintRange(100, 1);

        // Act
        var result = ruleSetRunner.Run(range);

        // Assert
        _outputHelper.WriteLine(string.Join("\n", result));
        result.Reverse();
        result.Should().Equal(expected);
    }
}