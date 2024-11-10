using System;

public class Program
{
    public static bool isOdd(int n)
    {
        if(n % 2 != 0)
        {
            return true;
        }
        return false;
    }
    
    public static bool isSquare(int n)
    {
        double res = Math.Sqrt(n);
        bool isSquare = (res % 1 == 0);
        return isSquare;
    }
    
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        for(int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            int n = Int32.Parse(input);
            if(isOdd(n) && isSquare(n))
            {
                Console.WriteLine("OS");
            }
            else if(isOdd(n) && !isSquare(n))
            {
                Console.WriteLine("O");
            }
            else if(isSquare(n) && !isOdd(n))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
