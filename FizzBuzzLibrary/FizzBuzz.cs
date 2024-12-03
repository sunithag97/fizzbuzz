namespace FizzBuzzLibrary;

public class FizzBuzz
{
    // write unit test
    // yaml script
    
    /// <summary>
    /// Return a fizzbuzz message by input value
    /// </summary>
    /// <param name="upperBound"></param>
    /// <returns></returns>
    public IEnumerable<string> GetFizzBuzz(int upperBound)
    {
        // 1 to 100
        //3 - fizz
        //5 - buzz
        
        for (var i = 1; i <= upperBound; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                yield return "fizz & buzz - " + i;
            }
            else if (i % 3 == 0)
            {
                yield return "fizz - " + i;
            }
            else if (i % 5 == 0)
            {
                yield return "buzz - " + i;
            }
            else
            {
                yield return i.ToString();
            }
        }
    }
}