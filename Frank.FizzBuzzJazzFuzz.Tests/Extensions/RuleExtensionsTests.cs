using Frank.FizzBuzzJazzFuzz.Extensions;
using Frank.FizzBuzzJazzFuzz.Models;

namespace Frank.FizzBuzzJazzFuzz.Tests.Extensions;

public class RuleExtensionsTests
{
    //[Fact]
    //public void RunRule_StateUnderTest_ExpectedBehavior()
    //{
    //	// Arrange
    //	var ruleExtensions = new RuleExtensions();
    //	Rule rule = default(global::Frank.FizzBuzzJazzFuzz.Models.Rule);
    //	uint value = 0;

    //	// Act
    //	var result = ruleExtensions.RunRule(
    //		rule,
    //		value);

    //	// Assert
    //	Assert.True(false);
    //}

    [Fact]
    public void RunRuleV2_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var rule = new RuleV2((x, y) => x % y == 0, "");
        uint value = 0;

        // Act
        // var result = rule.RunRuleV2(rule, value);

        // Assert
        Assert.True(false);
    }
}