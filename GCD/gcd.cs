using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int num1 = Int32.Parse(input.Split(" ")[0]);
        int num2 = Int32.Parse(input.Split(" ")[1]);
        int GCD = 1;
        
        if(num1 < num2)
        {
            for(int i = 1; i <= num1; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    GCD = i;
                }
            }
        }
        else
        {
            for(int i = 2; i <= num2; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    GCD = i;
                }
            }
        }
        
        Console.WriteLine(GCD);
    }
}
