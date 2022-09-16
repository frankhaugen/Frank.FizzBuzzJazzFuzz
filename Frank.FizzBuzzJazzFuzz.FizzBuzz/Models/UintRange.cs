namespace Frank.FizzBuzzJazzFuzz.Models;

/// <summary>
/// A range of numbers that can never be negative
/// </summary>
/// <param name="Start"></param>
/// <param name="End"></param>
public readonly record struct UintRange(uint Start, uint End);