namespace Frank.FizzBuzzJazzFuzz.Models;

/// <summary>
/// A rule is expected to define what some integer is divided with ends up with a whole number
/// </summary>
/// <param name="Divisor">What the integer value will be attempted to be divided with</param>
/// <param name="Text">The text that will replace the integer value if the rule is "true"</param>
public readonly record struct Rule(uint Divisor, string Text);