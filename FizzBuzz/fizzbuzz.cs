using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int x = Int32.Parse(strNums.Split(" ")[0]);
        int y = Int32.Parse(strNums.Split(" ")[1]);
        int n = Int32.Parse(strNums.Split(" ")[2]);
        
        for(int i = 1; i <= n; i++)
        {
            if(i % x == 0 && i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i % x == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(i % y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
