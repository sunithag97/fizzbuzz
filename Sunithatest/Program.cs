// See https://aka.ms/new-console-template for more information

using FizzBuzzLibrary;

public class Test
{
    static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz(int.MaxValue);

        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }
    
}