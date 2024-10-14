using System;

public class Program
{
    public static void Main(string[] args)
    {
        string phoneNumber = Console.ReadLine();
        if(phoneNumber.Substring(0, 3) == "555")
        {
            Console.WriteLine("1");
        }
        else 
        {
            Console.WriteLine("0");
        }
    }
}
