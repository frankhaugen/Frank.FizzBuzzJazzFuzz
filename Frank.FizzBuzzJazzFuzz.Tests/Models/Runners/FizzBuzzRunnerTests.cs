using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.FizzBuzz.Legacy;

namespace Frank.FizzBuzzJazzFuzz.Tests.Models.Runners;

public class FizzBuzzRunnerTests
{
    [Theory]
    [InlineData(100, "Files/fizzbuzz.txt")]
    public void Run_StateUnderTest_ExpectedBehavior(uint maxIterations, string assertionFilePath)
    {
        // Arrange
        var fizzBuzzRunner = new LegacyFizzBuzzRunner();
        var expected = File.ReadAllLines(assertionFilePath);

        // Act
        var result = fizzBuzzRunner.Run(maxIterations);

        // Assert
        result.Should().Equal(expected);
    }
}