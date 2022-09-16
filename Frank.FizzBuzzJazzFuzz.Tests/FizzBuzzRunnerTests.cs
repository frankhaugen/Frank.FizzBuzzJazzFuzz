using FluentAssertions;

using Frank.FizzBuzzJazzFuzz.FizzBuzz;

namespace Frank.FizzBuzzJazzFuzz.Tests;

public class FizzBuzzRunnerTests
{
    [Theory]
    [InlineData(100, "Files/fizzbuzz.txt")]
    public void Run_StateUnderTest_ExpectedBehavior(uint maxIterations, string assertionFilePath)
    {
        // Arrange
        var fizzBuzzRunner = new FizzBuzzRunner();
        var expected = File.ReadAllLines(assertionFilePath);

        // Act
        var result = fizzBuzzRunner.Run(maxIterations);

        // Assert
        result.Should().Equal(expected);
    }
}