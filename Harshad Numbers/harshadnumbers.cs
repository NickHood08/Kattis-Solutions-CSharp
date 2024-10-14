using System;

public class Program
{
    public static bool sumDigits(int num)
    {
        int x = num;
        int totalSumOfDigits = 0;
        while (num > 9)
        {
            totalSumOfDigits += num % 10;
            num /= 10;
        }
        totalSumOfDigits += num;
        return x % totalSumOfDigits == 0;
    }
    
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        
        while(!sumDigits(num))
        {
            num += 1;
        }
        Console.WriteLine(num);
    }
}
