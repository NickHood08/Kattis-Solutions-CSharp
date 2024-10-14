using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string strNum1 = Console.ReadLine();
        string strNum2 = Console.ReadLine();
        string strResult = Console.ReadLine();
        int num1 = Int32.Parse(strNum1);
        int num2 = Int32.Parse(strNum2);
        int result = Int32.Parse(strResult);
        if(result < 0)
        {
            Console.WriteLine("JEDI");
        }
        else
        {
            if(num2 > num1)
            {
                Console.WriteLine("SITH");
            }
            else
            {
                Console.WriteLine("VEIT EKKI");
            }
        }
    }
}
