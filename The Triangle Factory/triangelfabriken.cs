using System;

public class Program
{
    public static void Main(string[] arga)
    {
        string strNum1 = Console.ReadLine();
        string strNum2 = Console.ReadLine();
        string strNum3 = Console.ReadLine();
        
        int num1 = Int32.Parse(strNum1);
        int num2 = Int32.Parse(strNum2);
        int num3 = Int32.Parse(strNum3);
        
        if(num1 == 90 || num2 == 90 || num3 == 90)
        {
            Console.WriteLine("Ratvinklig Triangel");
        }
        else if(num1 > 90 || num2 > 90 || num3 > 90)
        {
            Console.WriteLine("Trubbig Triangel");
        }
        else
        {
            Console.WriteLine("Spetsig Triangel");
        }
    }
}
