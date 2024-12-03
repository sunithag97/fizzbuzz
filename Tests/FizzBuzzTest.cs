using FizzBuzzLibrary;
using Xunit;

namespace Tests;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(40)]
    [InlineData(50)]
    [InlineData(60)]
    public void FizzBuzzTestResult(int val)
    {
        
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz(val);

        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
        
        
    }
}