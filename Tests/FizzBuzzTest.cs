namespace Tests;

using Xunit;
using FizzBuzzLibrary;
using System.Collections.Generic;
using System.Linq;

public class FizzBuzzTest
{
    public static IEnumerable<object[]> GetFizzBuzz_ReturnsCorrectSequence()
    {
        return new List<object[]>
        {
            new object[]{new List<string>() { "1", "2", "fizz - 3", "4", "buzz - 5" }, 5},
            new object[]{new List<string>() { "1", "2", "fizz - 3" }, 3},
            new object[]{new List<string>() { "1" }, 1},
            new object[]{new List<string>() { }, 0},
            new object[]{ new List<string>(){"1", "2", "fizz - 3", "4", "buzz - 5", "fizz - 6", "7", "8", "fizz - 9", "buzz - 10", "11", "fizz - 12", "13", "14", "fizz & buzz - 15"}, 15 }
        };
    }
   
    [Theory]
    [MemberData(nameof(GetFizzBuzz_ReturnsCorrectSequence))]
    public void GetFizzBuzz_ReturnsCorrectSequence_ForUpperBound(List<string> expected, int upperBoundVal)
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();
       
        // Act
        var result = fizzBuzz.GetFizzBuzz(upperBoundVal).ToList();

        // Assert
        Assert.Equal(expected, result);
    }
}