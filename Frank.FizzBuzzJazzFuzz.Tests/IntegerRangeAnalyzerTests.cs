using System.Numerics;

using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.Models;
using Frank.FizzBuzzJazzFuzz.Rules;

namespace Frank.FizzBuzzJazzFuzz.Tests;

public static class MathConstants
{
    public static Single Deg2Rad = 0.01745329f;
}

public static class MathExtensions
{
    public static T Deg2Rad<T>(this T source) where T : class, INumber<T> => source * (MathConstants.Deg2Rad as T);
}

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