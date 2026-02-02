using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = int.Parse(strNum);
        int steps = 0;
        
        while(num > 1)
        {
            if(num % 2 != 0)
            {
                num += (num * 2) + 1;
            }
            else
            {
                num = num / 2;
            }
            steps++;
        }
        
        Console.WriteLine(steps);
    }
}
