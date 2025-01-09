using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = Int32.Parse(input.Split(" ")[0]);
        int a = Int32.Parse(input.Split(" ")[1]);
        int b = Int32.Parse(input.Split(" ")[2]);
        int fizzBuzz = 0;
        int fizz = 0;
        int buzz = 0;
        
        for(int i = 1; i <= n; i++)
        {
            if(i % a == 0 && i % b == 0)
            {
                fizzBuzz++;
            }
            else if(i % a == 0 && i % b != 0)
            {
                fizz++;
            }
            else if(i % b == 0 && i % a != 0)
            {
                buzz++;
            }
        }
        
        Console.WriteLine(fizz + " " + buzz + " " + fizzBuzz);
    }
}
