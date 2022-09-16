using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.Models;
using Frank.FizzBuzzJazzFuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.Tests;

public class IntegerRangeAnalyzerTests
{
    [Fact]
    public void AnalyzeFizzBuzz_Instance()
    {
        // Arrange
        var integerRangeAnalyzer = new IntegerRangeAnalyzer(new FizzBuzzRules());
        UintRange range = new(1, 100);
        var expected = File.ReadAllLines("Files/FizzBuzz.txt");

        // Act
        var result = integerRangeAnalyzer.Analyze(range);

        // Assert
        result.Should().Equal(expected);
    }

    [Fact]
    public void AnalyzeFizzBuzz_Static()
    {
        // Arrange
        var rules = new FizzBuzzRules();
        var range = new UintRange(1, 100);
        var expected = File.ReadAllLines("Files/FizzBuzz.txt");

        // Act
        var result = IntegerRangeAnalyzer.Analyze(rules, range);

        // Assert
        result.Should().Equal(expected);
    }
}