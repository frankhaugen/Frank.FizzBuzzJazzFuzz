using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Models;
using Frank.FizzBuzzJazzFuzz.FizzBuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.Tests.Rules;

public class FizzBuzzRulesTests
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(4, "4")]
    [InlineData(5, "Buzz")]
    [InlineData(6, "Fizz")]
    [InlineData(7, "7")]
    [InlineData(8, "8")]
    [InlineData(9, "Fizz")]
    [InlineData(10, "Buzz")]
    [InlineData(11, "11")]
    [InlineData(12, "Fizz")]
    [InlineData(13, "13")]
    [InlineData(14, "14")]
    [InlineData(15, "FizzBuzz")]
    public void RunRules_SingleValue(uint value, string expected)
    {
        // Arrange
        var fizzBuzzRules = new FizzBuzzRules();

        // Act
        var result = fizzBuzzRules.RunRules(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1, 100)]
    [InlineData(10, 16)]
    public void RunRules_RangeValue(uint from, uint to)
    {
        // Arrange
        var fizzBuzzRules = new FizzBuzzRules();
        var range = new UintRange(from, to);
        var expected = File.ReadAllLines("Files/FizzBuzz.txt")[new Range(new Index((int)from - 1), new Index((int)to))];

        // Act
        var result = fizzBuzzRules.RunRules(range);

        // Assert
        result.Should().Equal(expected);
    }
}