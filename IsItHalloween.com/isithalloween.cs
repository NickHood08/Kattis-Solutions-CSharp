using System;

public class Program
{
    public static void Main(string[] args)
    {
        string date = Console.ReadLine();
        if(date == "OCT 31" || date == "DEC 25")
        {
            Console.WriteLine("yup");
        }
        else
        {
            Console.WriteLine("nope");
        }
    }
}
