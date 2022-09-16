using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Extensions;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

using Xunit.Abstractions;

namespace Frank.FizzBuzzJazzFuzz.Tests.Models.Rulesets;

public class FizzBuzzRulesTests
{
    private readonly ITestOutputHelper _outputHelper;

    public FizzBuzzRulesTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var fizzBuzzRules = new FizzBuzzRules();
        var expected = File.ReadAllLines("Files/fizzbuzz.txt");
        var range = new UintRange(1, 100);

        // Act
        var result = fizzBuzzRules.RunRules(range);

        // Assert
        _outputHelper.WriteLine(string.Join("\n", result));
        result.Should().Equal(expected);
    }
}