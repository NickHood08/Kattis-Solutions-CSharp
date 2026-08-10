using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum1 = Console.ReadLine();
        string strNum2 = Console.ReadLine();
        string strNum3 = Console.ReadLine();
        
        int num1 = int.Parse(strNum1);
        int num2 = int.Parse(strNum2);
        int num3 = int.Parse(strNum3);
        
        if(num1 > num2 && num1 > num3)
        {
            Console.WriteLine(num1);
        }
        else if(num2 > num1 && num2 > num3)
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine(num3);
        }
    }
}
