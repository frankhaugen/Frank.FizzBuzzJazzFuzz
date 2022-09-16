using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.Models;
using Frank.FizzBuzzJazzFuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.Tests.Rules;

public class JazzFuzzRulesTests
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "3")]
    [InlineData(4, "Fuzz")]
    [InlineData(5, "5")]
    [InlineData(6, "6")]
    [InlineData(7, "7")]
    [InlineData(8, "Fuzz")]
    [InlineData(9, "Jazz")]
    [InlineData(10, "10")]
    public void RunRules_SingleValue(uint value, string expected)
    {
        // Arrange
        var jazzFuzzRules = new JazzFuzzRules();

        // Act
        var result = jazzFuzzRules.RunRules(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1, 100, 100, 1)]
    public void RunRules_RangeValue(uint from1, uint to1, uint from2, uint to2)
    {
        // Arrange
        var fizzBuzzRules = new FizzBuzzRules();
        var jazzFuzzRules = new JazzFuzzRules();
        var range1 = new UintRange(from1, to1);
        var range2 = new UintRange(from2, to2);
        var expected = File.ReadAllLines("Files/FizzBuzzJazzFuzz.txt");

        // Act
        var result1 = fizzBuzzRules.RunRules(range1);
        var result2 = jazzFuzzRules.RunRules(range2);
        var result = result1.Concat(result2);

        // Assert
        result.Should().Equal(expected);
    }
}