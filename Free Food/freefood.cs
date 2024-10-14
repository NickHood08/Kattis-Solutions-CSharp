using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int min = 400;
        int max = -1;
        bool[] free = new bool[366];
        int numDays = 0;
        while(num > 0)
        {
            string input = Console.ReadLine();
            int num1 = Int32.Parse(input.Split(" ")[0]);
            int num2 = Int32.Parse(input.Split(" ")[1]);
            min = Math.Min(min, num1);
            max = Math.Max(max, num2);
            for(int i = num1; i <= num2; i++)
            {
                free[i] = true;
            }
            num -= 1;
        }
        
        for(int i = min; i <= max; i++)
        {
            if(free[i])
            {
                numDays += 1;
            }
        }
        Console.WriteLine(numDays);
    }
}
